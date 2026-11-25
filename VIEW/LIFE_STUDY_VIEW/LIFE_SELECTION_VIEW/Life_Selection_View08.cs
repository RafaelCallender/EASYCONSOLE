using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW;
using System;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    internal class Life_Selection_View08
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static The_Book_Of_Jubilees01 The_Book_Of_Jubilee = new The_Book_Of_Jubilees01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text05 Ai_Text_To_T05 = new Ai_Text_To_Text05();
        private static Book_of_Enoch01 Book_of_E01 = new Book_of_Enoch01();
        private static The_Bible_Services01 The_Bible_Serv01 = new The_Bible_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();
        private static string filepath = File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile01].Trim();
        private static bool content_bool = File_S01.Read_Document01(filepath, out data01[50]);
        private static string content_string = data01[50];
        private int file_count = 0;
        public Life_Selection_View08()
        {
            load_Life_Selection_View01().Wait();
        }

        private string load_Life_Selection_View01_string()
        {
            return $"1. ask questions about any of the books \n" +
                        $"2.) go back\n";
        }

        private async Task load_Life_Selection_View01()
        {



            Console.WriteLine(load_Life_Selection_View01_string());
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                    {

                        switch (int.Parse(data01[1]))
                        {
                            case 1:

                                data01[2] = "what questions do you have";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (data01[3] != "stop99")
                                    {
                                        Action[] chunkLoader = new Action[]
                                                     {
                                            The_Book_Of_Jubilee.LoadBookChunks,
                                            The_Bible_Serv01.LoadBibleChunks,
                                            Book_of_E01.LoadEnochChunks
                                                     };
                                        //   string resualts01 = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.all_books);
                                        string results = await Ai_Text_To_T05.text_to_text_content01(data01[3], chunkLoader);
                                        // resualts01 = File_H01.file_saved(data01[3], results, (int)File_Helper01.file_path_data01_enum.all_books);
                                        Console.WriteLine(results);
                                        Console.WriteLine(load_Life_Selection_View01_string());
                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                        break;
                                    }
                                    else
                                    {

                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {


                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;

                                }
                            case 2:
                                new Life_Main_View01();
                                break;

                        }




                    }
                    else
                    {

                        Console.WriteLine(data01[24]);
                        data01[1] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
                else
                {

                    Console.WriteLine(data01[23]);
                    data01[1] = Console.ReadLine() ?? string.Empty;
                    continue;
                }
            }
        }

    }
}
