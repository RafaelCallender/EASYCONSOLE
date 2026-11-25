using LLama;
using LLama.Common;
using LLama.Native;
using LLama.Sampling;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using System.Text.Json.Serialization;

return await RunAsync(args);

static async Task<int> RunAsync(string[] args)
{
    var serverMode = args.Contains("--server", StringComparer.Ordinal);
    var promptIndex = Array.IndexOf(args, "--prompt");
    var prompt = promptIndex >= 0 && promptIndex + 1 < args.Length
        ? args[promptIndex + 1]
        : null;
    var modelIndex = Array.IndexOf(args, "--model");
    var modelArgument = modelIndex >= 0 && modelIndex + 1 < args.Length
        ? args[modelIndex + 1]
        : args.FirstOrDefault(argument =>
            !argument.StartsWith("--", StringComparison.Ordinal));
    var modelPath = modelArgument is not null
        ? Path.GetFullPath(modelArgument)
        : FindDefaultModelPath();

    if (!File.Exists(modelPath))
    {
        Console.Error.WriteLine("GGUF model file not found.");
        Console.Error.WriteLine($"Expected path: {modelPath}");
        return 1;
    }

    var customBackendPath = Path.Combine(
        AppContext.BaseDirectory,
        "native",
        "linux-x64",
        "libllama.so");
    var hasCustomBackend =
        RuntimeInformation.IsOSPlatform(OSPlatform.Linux) &&
        RuntimeInformation.ProcessArchitecture == Architecture.X64 &&
        File.Exists(customBackendPath);

    if (hasCustomBackend)
    {
        NativeLibraryConfig.LLama.WithLibrary(customBackendPath);
    }
    else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) &&
             RuntimeInformation.ProcessArchitecture == Architecture.X64 &&
             !Avx.IsSupported)
    {
        Console.Error.WriteLine(
            "Local GGUF inference is unavailable because this x64 CPU does not support AVX.");
        Console.Error.WriteLine(
            "Build the compatible backend by running EASYCONSOLE/AI_RUNNER/build-native-backend.sh.");
        return 1;
    }

    if (prompt is null)
        Console.WriteLine($"Loading AI model from {modelPath}...");

    try
    {
        var parameters = new ModelParams(modelPath)
        {
            ContextSize = 2048,
            GpuLayerCount = 0,
            Threads = Math.Max(1, Environment.ProcessorCount / 2)
        };

        using var model = LLamaWeights.LoadFromFile(parameters);
        if (serverMode)
            return await RunServerAsync(model, parameters);

        using var context = model.CreateContext(parameters);
        var executor = new InteractiveExecutor(context);
        var history = new ChatHistory();
        history.AddMessage(
            AuthorRole.System,
            "You are a helpful AI assistant. Answer clearly and concisely.");
        var session = new ChatSession(executor, history);
        var inferenceParams = new InferenceParams
        {
            MaxTokens = 256,
            SamplingPipeline = new DefaultSamplingPipeline()
        };

        if (prompt is not null)
        {
            await WriteResponseAsync(session, inferenceParams, prompt);
            return 0;
        }

        Console.WriteLine("Local AI is ready. Type exit to quit.\n");

        while (true)
        {
            Console.Write("You: ");
            var input = Console.ReadLine();
            if (input is null || input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                break;

            if (string.IsNullOrWhiteSpace(input))
                continue;

            Console.Write("AI: ");
            await WriteResponseAsync(session, inferenceParams, input);
            Console.WriteLine("\n");
        }

        static async Task WriteResponseAsync(
            ChatSession session,
            InferenceParams inferenceParams,
            string prompt)
        {
            await foreach (var token in session.ChatAsync(
                new ChatHistory.Message(AuthorRole.User, prompt),
                inferenceParams))
            {
                Console.Write(token);
            }
        }

        return 0;
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine("Failed to load or run the local GGUF model.");
        Console.Error.WriteLine(ex);
        return 1;
    }
}

static async Task<int> RunServerAsync(LLamaWeights model, ModelParams parameters)
{
    var contexts = new Dictionary<string, LLamaContext>(StringComparer.Ordinal);
    var sessions = new Dictionary<string, ChatSession>(StringComparer.Ordinal);
    var inferenceParams = new InferenceParams
    {
        MaxTokens = 256,
        SamplingPipeline = new DefaultSamplingPipeline()
    };

    await WriteMessageAsync(new RunnerMessage { Type = "ready" });
    try
    {
        string? line;
        while ((line = await Console.In.ReadLineAsync()) is not null)
        {
            RunnerRequest? request;
            try
            {
                request = JsonSerializer.Deserialize<RunnerRequest>(line);
            }
            catch (JsonException)
            {
                await WriteMessageAsync(new RunnerMessage
                {
                    Type = "error",
                    Message = "Invalid chat request."
                });
                continue;
            }

            if (request is null || string.IsNullOrWhiteSpace(request.Id) ||
                string.IsNullOrWhiteSpace(request.Prompt))
            {
                await WriteMessageAsync(new RunnerMessage
                {
                    Type = "error",
                    Message = "A conversation ID and prompt are required."
                });
                continue;
            }

            try
            {
                if (!sessions.TryGetValue(request.Id, out var session))
                {
                    var context = model.CreateContext(parameters);
                    var history = new ChatHistory();
                    history.AddMessage(
                        AuthorRole.System,
                        "You are a helpful AI assistant. Answer clearly and concisely.");
                    session = new ChatSession(new InteractiveExecutor(context), history);
                    contexts.Add(request.Id, context);
                    sessions.Add(request.Id, session);
                }

                var response = new System.Text.StringBuilder();
                await foreach (var token in session.ChatAsync(
                    new ChatHistory.Message(AuthorRole.User, request.Prompt),
                    inferenceParams))
                {
                    response.Append(token);
                }

                await WriteMessageAsync(new RunnerMessage
                {
                    Type = "response",
                    Id = request.Id,
                    Text = response.ToString()
                });
            }
            catch (Exception ex)
            {
                await WriteMessageAsync(new RunnerMessage
                {
                    Type = "response",
                    Id = request.Id,
                    Error = ex.Message
                });
            }
        }
    }
    finally
    {
        foreach (var context in contexts.Values)
            context.Dispose();
    }

    return 0;
}

static Task WriteMessageAsync(RunnerMessage message)
{
    Console.WriteLine(JsonSerializer.Serialize(message));
    Console.Out.Flush();
    return Task.CompletedTask;
}

static string FindDefaultModelPath()
{
    var directory = new DirectoryInfo(AppContext.BaseDirectory);
    while (directory is not null)
    {
        var modelPath = Path.Combine(
            directory.FullName,
            "EASY_CALLENDER01",
            "FILES",
            "EXTERNAL",
            "GGUF",
            "GGUF_LOCAL",
            "text_to_text_local01.gguf");

        if (File.Exists(modelPath))
            return modelPath;

        directory = directory.Parent;
    }

    return Path.Combine(
        AppContext.BaseDirectory,
        "FILES",
        "EXTERNAL",
        "GGUF",
        "GGUF_LOCAL",
        "text_to_text_local01.gguf");
}

sealed class RunnerRequest
{
    [JsonPropertyName("id")]
    public string Id { get; init; } = string.Empty;

    [JsonPropertyName("prompt")]
    public string Prompt { get; init; } = string.Empty;
}

sealed class RunnerMessage
{
    [JsonPropertyName("type")]
    public string Type { get; init; } = string.Empty;

    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("error")]
    public string? Error { get; init; }

    [JsonPropertyName("message")]
    public string? Message { get; init; }
}
