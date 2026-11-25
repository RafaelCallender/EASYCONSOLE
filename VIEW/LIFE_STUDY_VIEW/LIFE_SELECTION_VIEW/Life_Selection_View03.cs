using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{

    internal class Life_Selection_View03
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static The_Book_Of_Jubilees01 The_Book_Of_Jubilee = new The_Book_Of_Jubilees01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        //        private static Ai_Text_To_Text04 Ai_Text_To_T04 = new Ai_Text_To_Text04();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static File_Manger01 File_M01 = new File_Manger01();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();

        private static string menu_string01 = $"Read the Jubilees\n" +
                            $"audio book of the Jubilees\n" +
                            $"questions about the Jubilees\n" +
                           $"write your thoughts\n" +
                                           $"Speak your thoughts\n" +
                                           $"listen to past recorded thoughts\n" +
                                           $"read past recorded thoughts\n" +
                                           $"go back\n"
                                           ;
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static string book01 = string.Empty;
        private static string filepath = File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile03].Trim();
        private static bool content_bool = File_S01.Read_Document01(filepath, out data01[50]);
        private static string content_string = data01[50];
        public Life_Selection_View03()
        {
            load_Selection01();
            book01 = The_Book_Of_Jubilee.read_full_book_text();
        }

        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1])].Trim();
            switch (procedure)
            {
                case "Read the Jubilees":
                    _commands.Add(procedure, Read_the_Jubilees);
                    break;
                case "audio book of the Jubilees":
                    _commands.Add(procedure, audio_book_of_the_Jubilees);
                    break;
                case "questions about the Jubilee":
                    _commands.Add(procedure, questions_about_the_Jubilee);
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
        private void Read_the_Jubilees()
        {
            Console.WriteLine(book01);
        }
        private async void audio_book_of_the_Jubilees()
        {

            await Audio_Serv01.text_to_speech_linux01(book01);
            Console.WriteLine(book01);
        }
        private void questions_about_the_Jubilee()
        {
            Console.WriteLine("needs work");
        }
        private void record_thoughts()
        {
            Console.WriteLine("needs work");

        }

        private void go_back()
        {
            new Life_Main_View01();
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
