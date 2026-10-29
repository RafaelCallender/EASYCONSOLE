using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using System.Diagnostics;
namespace EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string menu_string = $"Ai text generation \n" +
                     $"Ai text generation for developers \n" +
                     $"Ai text generation for web developers \n" +
                     $"go back\n";

        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Ai_Selection_View02()
        {

            load_Selection01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {

                case "Ai text generation":
                    _commands[procedure] = Ai_text_generation;
                    break;
                case "Ai text generation for developers":
                    _commands[procedure] = Ai_text_generation_for_developers;
                    break;
                case "Ai text generation for web developers":
                    _commands[procedure] = Ai_text_generation_for_web_developers;
                    break;
                case "go back":
                    _commands[procedure] = go_back;
                    break;

            }

        }
        private void Ai_text_generation()
        {
            var runnerProjectPath = FindRunnerProjectPath();
            if (runnerProjectPath is null)
            {
                Console.WriteLine("Could not locate the .NET 8 AI runner project.");
                Console.WriteLine("Run EASYCONSOLE/AI_RUNNER/EASYAI_RUNNER.csproj directly.");
                return;
            }

            var projectRoot = Directory.GetParent(
                Path.GetDirectoryName(runnerProjectPath)!)!.Parent!.FullName;
            var startInfo = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = projectRoot,
                UseShellExecute = false
            };
            startInfo.ArgumentList.Add("run");
            startInfo.ArgumentList.Add("--project");
            startInfo.ArgumentList.Add(runnerProjectPath);
            startInfo.ArgumentList.Add("--");
            startInfo.ArgumentList.Add(File_Manger05.text_to_text_local01_gguf);

            try
            {
                using var runner = Process.Start(startInfo);
                if (runner is null)
                {
                    Console.WriteLine("Failed to start the .NET 8 AI runner.");
                    return;
                }

                runner.WaitForExit();
                if (runner.ExitCode != 0)
                    Console.WriteLine($"The AI runner exited with code {runner.ExitCode}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to start the .NET 8 AI runner.");
                Console.WriteLine(ex);
            }
        }

        private static string? FindRunnerProjectPath()
        {
            var directory = new DirectoryInfo(AppContext.BaseDirectory);
            while (directory is not null)
            {
                var projectPath = Path.Combine(
                    directory.FullName,
                    "EASYCONSOLE",
                    "AI_RUNNER",
                    "EASYAI_RUNNER.csproj");

                if (File.Exists(projectPath))
                    return projectPath;

                directory = directory.Parent;
            }

            return null;
        }
        private void Ai_text_generation_for_developers()
        {
            Console.WriteLine("not yet developed");
        }
        private void Ai_text_generation_for_web_developers()
        {
            Console.WriteLine("not yet developed");
        }
        private void go_back()
        {
            new Ai_Main_View01();
        }

        private void load_Selection01()
        {
            Console.WriteLine(ShowMenu());
            data01[1] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                {
                    int selection = int.Parse(data01[1].Trim());
                    int stringlength = menu_array.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array[selection].Trim();
                        load_Selection_data01();
                        if (_commands.TryGetValue(key, out Action action))
                        {
                            action();
                            _commands.Clear();

                        }
                        else
                        {
                            Console.WriteLine($"{key} command not found");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);

                }
            }
        }
    }
}
