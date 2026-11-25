using System;
using System.Collections.Generic;
using System.Text;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_MAIN_VIEW;
namespace EASYPROJECT01.EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NFL_VIEW
{
    internal class Sports_Selection_Nfl_View01
    {

        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Sports_Selection_Nfl_View01()
        {
            load_Sports_Selection_Nfl_View01();
        }
        private string load_Sports_Selection_Nfl_View01_string()
        {

            return
                   $"1.) NFL\n" +
                   $"2.) go back\n";

        }
        private void load_Sports_Selection_Nfl_View01()
        {


            Console.WriteLine(load_Sports_Selection_Nfl_View01_string());
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
                                Console.WriteLine("not yet dvelop");
                                Console.WriteLine(load_Sports_Selection_Nfl_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:
                                new Sports_Main_View();
                                break;
                            default:
                                Console.WriteLine(load_Sports_Selection_Nfl_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                continue;

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