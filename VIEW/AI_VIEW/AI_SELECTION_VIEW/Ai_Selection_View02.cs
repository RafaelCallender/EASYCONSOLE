using EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL.SQL_MANAGER.SQL_MANAGER_CHEMISTRY;
using EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW;
using static EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER.File_Helper01;

namespace EASYCONSOLE.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Ai_Text_To_Text01 Ai_Text_To_T01 = new Ai_Text_To_Text01();
        private static File_Helper01 File_H01 = new File_Helper01();
        public Ai_Selection_View02()
        {
            load_Ai_Selection_View02().Wait();
        }

private string load_Ai_Selection_View02_string()
        {
            
return  $"1.) Ai text gemeration \n" +
                        $"2.) Ai text gemeration for developers \n" +
						$"3.) Ai text gemeration for web developers \n" +
                        $"4.) to go back\n";
        }

        private async Task load_Ai_Selection_View02()
        {

      
            Console.WriteLine(load_Ai_Selection_View02_string());
            data01[1] = Console.ReadLine() ?? string.Empty;
            while (true)
            {

                if (Security_Serv01.empty_string(data01[1],out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1],out data01[24]) == true)
                    {

                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                                string res01 = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.question);
                                data01[2] = "Tell me whats on your mind\n";
                                     
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
								
                                if (Security_Serv01.empty_string(data01[3],out data01[25]) == true)
                                {
                                  if(data01[3]!="stop99")
								  {
						            data01[4] = await Ai_Text_To_T01.text_to_text_generator01(data01[3]);

                                    res01 = File_H01.file_saved(data01[3],data01[4], (int)File_Helper01.file_path_data01_enum.question);
                                        Console.WriteLine(res01);
                                          Console.WriteLine(data01[2]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                     			  
								  }
								  else
								  {
									  
								      Console.WriteLine(data01[25]);
                                       Console.WriteLine(data01[2]);
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
                                data01[2] = "lets develop together. how can i help?";
                                string res = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.developers);
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                          
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                        if(data01[3]!="stop99")
								  {
									       data01[4] = await Ai_Text_To_T01.text_to_text_generator02(data01[3]);

                                         res = File_H01.file_saved(data01[3], data01[4], (int)File_Helper01.file_path_data01_enum.developers); 
                              
                                        Console.WriteLine(res);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
									  
									  
									  
								  }
								  else
								  {
                                        Console.WriteLine(data01[24]);
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
                       

                            case 3:
                               
                                             data01[2] = "lets make your better. how can i help?";
                                string res02 = File_H01.file_saved("", "", (int)File_Helper01.file_path_data01_enum.webb_question);
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                          
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                  if(data01[3]!="stop99")
								  {
									 data01[4] = await Ai_Text_To_T01.text_to_text_generator03(data01[3]);

                                         res02 = File_H01.file_saved(data01[3], data01[4], (int)File_Helper01.file_path_data01_enum.webb_question); 
                              
                                        Console.WriteLine(res02);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;  
								  }
								  else
								  {
									  
								    Console.WriteLine(data01[23]);
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
								     case 4:
                                new Ai_Main_View01();
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