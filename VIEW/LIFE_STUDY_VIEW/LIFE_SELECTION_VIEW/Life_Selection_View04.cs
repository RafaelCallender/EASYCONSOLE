using EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.BOOK_OF_ENOCH;
using EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BIBLE;
using EASY_CALLENDER01.SERVICES.LIFE_STUDY_SERVICES.THE_BOOK_OF_JUBILEES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW
{
    internal class Life_Selection_View04
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static The_Book_Of_Jubilees01 The_Book_Of_Jubilee = new The_Book_Of_Jubilees01();
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Ai_Text_To_Text05 Ai_Text_To_T05 = new Ai_Text_To_Text05();
        private static Book_of_Enoch01 Book_of_E01 = new Book_of_Enoch01();
        private static The_Bible_Services01 The_Bible_Serv01 = new The_Bible_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private int file_count = 0;             
        public Life_Selection_View04()
        {
            load_Life_Selection_View01().Wait();
        }

        private async Task load_Life_Selection_View01()
        {

            data01[0] = $"1. ask questions about any of the books \n" +
                        $"2.) go back\n";

            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                if (Security_Serv01.empty_string(data01[1],out data01[23])  == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1],out data01[24])  == true)
                    {

                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                          
                                 data01[2] = "what questions do you have";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
if(data01[3]!="stop99")
{
	                   Action[] chunkLoader = new Action[]
                                    {
                                            The_Book_Of_Jubilee.LoadBookChunks,
                                            The_Bible_Serv01.LoadBibleChunks,
                                            Book_of_E01.LoadEnochChunks
                                    };
                                    string resualts01 = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.all_books);
                                    string results = await Ai_Text_To_T05.text_to_text_content01(data01[3], chunkLoader);
                                     resualts01 = File_H01.file_saved(data01[3], results, (int)File_Helper01.file_path_data01_enum.all_books);
                                    Console.WriteLine(resualts01);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
}
else
{
	
	return;
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
                                return;

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
