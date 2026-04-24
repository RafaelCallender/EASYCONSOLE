using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_SCIENCE_SERVICES.SQL_CHEMISTRY_SERVICES;
using EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES;
using EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_HELPER;

namespace EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    internal class Science_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        
private static Chemistry_Services02 Chemistry_Serv02=new Chemistry_Services02();  

   private static Chemistry_Helper01 Chemistry_H01=new Chemistry_Helper01();  

    private static int count = 0;    
private static Sql_Chemistry_Services02 Sql_Chemistry_Serv02 = new Sql_Chemistry_Services02();   
        public Science_Selection_View02()
        {
            load_Science_Selection_View02().Wait();
        }
        private string load_Science_Selection_View02_String()
        {
            return   $"1.)find_element_using_sqlexpress\n" +
                     $"2.)view_all_elements_using_sqlexpress\n" +
                     $"3.)find_category_elements_using_sqlexpress\n" +
                     $"4.) go back\n";
 
        }
        private async Task load_Science_Selection_View02()
        {

            Console.WriteLine(load_Science_Selection_View02_String());
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

                                data01[2] = "Search Element";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {

                                      data01[4] = Chemistry_Serv02.find_element_using_sqlexpress(data01[3]);
                                    Console.WriteLine(data01[4]);
                                
            Console.WriteLine(load_Science_Selection_View02_String());
            data01[1] = Console.ReadLine() ?? string.Empty;
            break;


                                }
                                else
                                {
                                  
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                                                                       
                            case 2:
                                data01[4] = Sql_Chemistry_Serv02.view_all_elements();
                                Console.WriteLine(data01[4]);
                          Console.WriteLine(load_Science_Selection_View02_String());
            data01[1] = Console.ReadLine() ?? string.Empty;
            break;
 case 3:
                                count = 0;
                                foreach (var a in Chemistry_H01.data_array)
                                {
                                    count++;
                                    data01[2] += $"{count}.) {a}\n";
                                }
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3],out data01[24]) == true)
                                    {
                                        data01[4] = await Chemistry_Serv02.find_category_elements_using_sqlexpress(int.Parse(data01[3]));
                                        Console.WriteLine(data01[4]);
                                                           
            Console.WriteLine(load_Science_Selection_View02_String());
            data01[1] = Console.ReadLine() ?? string.Empty;
            break;
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
                                new Science_Main_View01();  
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