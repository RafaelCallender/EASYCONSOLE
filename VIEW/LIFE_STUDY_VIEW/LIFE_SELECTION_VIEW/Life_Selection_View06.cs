using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    internal class Life_Selection_View06
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        private static The_Bible_Services01 The_Bible_Serv01 = new The_Bible_Services01();
        private static string menu_string01 = $"Read book of judith\n" +
                       $"audio book_of judith\n" +
                       $"questions book of judith\n" +
                       $"record thoughts\n" +
                       $"go back\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static File_Manger13 File_M13 = new File_Manger13();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static string filepath = File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile06].Trim();
        private static bool content_bool = File_S01.Read_Document01(filepath, out data01[50]);
        private static string content_string = data01[50];
        private static string book01 = string.Empty;
        public Life_Selection_View06()
        {
            load_Selection01();
            book01 = File_M13.book_of_judith_pdf;
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

            string procedure = menu_array01[int.Parse(data01[1])].Trim();
            switch (procedure)
            {

                case "Read Book of judith":
                    _commands.Add(procedure, Read_Book_of_judith);
                    break;
                case "audio Book of judith":
                    _commands.Add(procedure, audio_Book_of_judith);
                    break;
                case "questions Book of judith":
                    _commands.Add(procedure, questions_Book_of_judith);
                    break;
                case "write your thoughts":
                    _commands.Add(procedure, write_your_thoughts);
                    break;
                case "Speak your thoughts":
                    _commands.Add(procedure, Speak_your_thoughts);
                    break;
                case "listen to past recorded thoughts":
                    _commands.Add(procedure, listen_to_past_recorded_thoughts);
                    break;
                case "read past recorded thoughts":
                    _commands.Add(procedure, read_past_recorded_thoughts);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
            }
        }
        private async void write_your_thoughts()
        {

            Console.WriteLine("type");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                if (File_S01.write_to_texfile01(filepath, data01[3], out data01[26]) == true)
                {
                    Console.WriteLine(data01[26]);
                }
                else
                {
                    Console.WriteLine(data01[26]);
                }

            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void Read_Book_of_judith()
        {
            Console.WriteLine(book01);
        }
        private async void audio_Book_of_judith()
        {
            Console.WriteLine(book01);
            await Audio_Serv01.text_to_speech_linux01(book01);
        }
            private void questions_Book_of_judith()
            {

                Console.WriteLine("type");
                data01[3] = Console.ReadLine() ?? string.Empty;
                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                {
                    if (File_S01.write_to_texfile01(filepath, data01[3], out data01[26]) == true)
                    {
                        Console.WriteLine("not yet developed");
                    }
                    else
                    {
                        Console.WriteLine(data01[26]);
                    }

                }
                else
                {
                    Console.WriteLine(data01[23]);
                }

            }
            private void Speak_your_thoughts()
            {
                Console.WriteLine("not yet developed");
            }
            private async void listen_to_past_recorded_thoughts()
            {
                if (content_bool == true)
                {
                    await Audio_Serv01.text_to_speech_linux01(content_string);
                    Console.WriteLine(content_string);
                }
                else
                {
                    Console.WriteLine(content_string);
                }
            }
            private void read_past_recorded_thoughts()
            {
                if (content_bool == true)
                {
                    Console.WriteLine(content_string);
                }
                else
                {
                    Console.WriteLine(content_string);
                }

            }
        private void go_back()
        {
            new Life_Main_View01();
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
