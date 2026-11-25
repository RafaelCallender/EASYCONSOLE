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
        private static string menu_string = $"Ai text to text generation\n" +
                                           $"Ai speech to text generation\n" +
                                           $"go back";

        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Ai_Text_To_Text07 Ai_Text_To_T07 = new Ai_Text_To_Text07();

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

                case "Ai text to text generation":
                    _commands[procedure] = Ai_text_to_text_generation;
                    break;
                case "Ai speech to text generation":
                    _commands[procedure] = Ai_speech_to_text_generation;
                    break;
                case "go back":
                    _commands[procedure] = go_back;
                    break;

            }

        }
        private void Ai_text_to_text_generation()
        {
            Console.WriteLine(Ai_Text_To_T07.Ai_text_generation01());
        }
        private void Ai_speech_to_text_generation()
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
