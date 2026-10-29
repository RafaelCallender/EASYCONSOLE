using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Services01 Language_Serv01 = new Language_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static Language_Helper01 Language_H01 = new Language_Helper01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static string menu_string = $"Tranlate_Text\n" +
           $"Tranlate_Text 01\n" +
       $"Batch_Translation\n" +
       $"Translate_JSON\n" +
       $"Translate_HTML\n" +
       $"Detect_Language\n" +
       $"Translate text to voice\n" +
       $"Supported_languages\n" +
$"go back\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static File_Manger01 File_M01 = new File_Manger01();

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Translate_Selection_View01()
        {
            load_Selection01();
        }

        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1])].Trim();
            switch (procedure)
            {


                case "Tranlate_Text":
                    _commands.Add(procedure, Tranlate_Text);
                    break;
                case "Batch_Translation":
                    _commands.Add(procedure, Batch_Translation);
                    break;
                case "Translate_JSON":
                    _commands.Add(procedure, Translate_JSON);
                    break;
                case "Translate_HTML":
                    _commands.Add(procedure, Translate_HTML);
                    break;
                case "Detect_Language":
                    _commands.Add(procedure, Detect_Language);
                    break;
                case "Supported_languages":
                    _commands.Add(procedure, Supported_languages);
                    break;
                case "Translate text to voice":
                    _commands.Add(procedure, Translate_text_to_voice);
                    break;
                case "Tranlate_Text 01":
                    _commands.Add(procedure, Tranlate_Text_01);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;

            }
        }

        private string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private string ShowMenu01()
        {
            string[] aray01 = File_Manger01.Language_Name.Split("\n");
            for (int i = 0; i < aray01.Length; i++)
            {
                data01[20] += $"{i}.){aray01[i]}\n";
            }
            return data01[20];
        }
        private async void Tranlate_Text()
        {

            data01[3] = $"{Language_H01.data_array01[1]}\n" +
                $"--------------------------------------------\n" +
                $"{ShowMenu01()}";
            Console.WriteLine(data01[3]);
            data01[4] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[4], out data01[23]) == true)
            {
                data01[5] = $"{Language_H01.data_array01[0]}";
                Console.WriteLine(data01[5]);
                data01[6] = Console.ReadLine() ?? string.Empty;
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    var res = await Security_Serv01.is_connected_to_netwrok_linux();
                    if (res.success == true)
                    {
                        data01[7] = await Language_Serv01.Tranlate_Text(Language_H01.code[int.Parse(data01[4])].Trim(), data01[6].Trim());
                        Console.WriteLine(data01[7]);
                    }
                    else
                    {
                        Console.WriteLine(res.output);
                    }
                }
                else
                {
                    Console.WriteLine(data01[23]);

                }
            }
            else
            {
                Console.WriteLine(data01[23]);

            }

        }
        private async void Tranlate_Text_01()
        {
            data01[7] = "only availbe for web or mobile";

            Console.WriteLine(data01[7]);
        }
        private async void Translate_text_to_voice()
        {



            data01[3] = $"{Language_H01.data_array01[1]}\n" +
                $"--------------------------------------------\n" +
                $"{ShowMenu01()}";
            Console.WriteLine(data01[3]);
            data01[4] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[4], out data01[23]) == true)
            {
                data01[5] = $"{Language_H01.data_array01[0]}";
                Console.WriteLine(data01[5]);
                data01[6] = Console.ReadLine() ?? string.Empty;
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    var res = await Security_Serv01.is_connected_to_netwrok_linux();
                    if (res.success == true)
                    {
                        data01[7] = await Language_Serv01.Tranlate_Text(Language_H01.code[int.Parse(data01[4])].Trim(), data01[6].Trim());
                        await Audio_Serv01.text_to_speech_linux01(data01[7]);
                        Console.WriteLine(data01[7]);
                    }
                    else
                    {
                        Console.WriteLine(res.output);
                    }
                }
                else
                {
                    Console.WriteLine(data01[23]);

                }
            }
            else
            {
                Console.WriteLine(data01[23]);

            }



        }
        private async void Batch_Translation()
        {
            data01[7] = "not yet developed";
            Console.WriteLine(data01[7]);
        }
        private async void Translate_JSON()
        {
            data01[7] = "not yet developed";
            Console.WriteLine(data01[7]);
        }
        private async void Translate_HTML()
        {
            data01[7] = "not yet developed";
            Console.WriteLine(data01[7]);
        }
        private async void Detect_Language()
        {
            Console.WriteLine("type message");
            data01[3] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[3], out data01[23]))
            {
                var res = await Security_Serv01.is_connected_to_netwrok_linux();
                if (res.success == true)
                {
                    Console.WriteLine($"{await Language_Serv01.Detect_Language(data01[3])}");
                }
                else
                {
                    Console.WriteLine(res.output);
                }
            }
            else
            {

                Console.WriteLine(data01[23]);
            }

        }
        private async void Supported_languages()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                data01[7] = await Language_Serv01.Supported_languages();
                Console.WriteLine(data01[7]);
            }
            else
            {
                Console.WriteLine(res.output);
            }

        }
        private void go_back()
        {
            new Translate_Main_View01();
        }
        private void load_Selection01()
        {

            Console.WriteLine($"{ShowMenu()}");
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
