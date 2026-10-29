using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection11
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string01 =
                                         $"Text to speech linux 01\n" +
                                         $"Read audio file\n" +
                                       $"back\n";

        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);


        public Test_Selection11()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[20] += $"{i}.){menu_array01[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {
                case "Text to speech linux 01":
                    _commands[procedure] = text_to_speech_linux01;

                    break;
      
                case "Read audio file":
                    _commands[procedure] = read_audio_file01;
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;

            }

        }
        private async void text_to_speech_linux01()
        {
            Console.WriteLine("type");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                await Audio_Serv01.text_to_speech_linux01(data01[3]);
                Console.WriteLine(data01[3]);
            }
            else
            {
                Console.WriteLine(data01[23]);

            }

        }


        private async void read_audio_file01()
        {
            Console.WriteLine("type");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {

                await Audio_Serv01.read_audio_file01();
                Console.WriteLine(data01[3]);
            }
            else
            {
                Console.WriteLine(data01[23]);

            }

        }
        private void back()
        {
            new Test_Main_View01();
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
                    int stringlength = menu_array01.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array01[selection].Trim();
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
