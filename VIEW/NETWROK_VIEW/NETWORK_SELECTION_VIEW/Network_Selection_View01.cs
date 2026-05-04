using EASY_CALLENDER01.SERVICES.NETWORK_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using System;
using System.Collections.Generic;
using System.Text;
using EASYCONSOLE.VIEW.NETWROK_VIEW.NETWORK_MAIN_VIEW;
namespace EASYCONSOLE.VIEW.NETWROK_VIEW.NETWORK_SELECTION_VIEW
{
    internal class Network_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Network_Services01 Network_S01 = new Network_Services01();
        public Network_Selection_View01()
        {
            load_Network_Selection_View01();
        }

        private string load_Network_Selection_View01_string()
        {
            return      $"1.) scan network\n" +
                        $"2.) network monitor\n" +
                        $"3.) network_monitor01\n" +
                        $"4.) go back\n";
        }
        private void load_Network_Selection_View01()
        {


            Console.WriteLine(load_Network_Selection_View01_string());
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


                                Console.WriteLine(Network_S01.scan_netwrok());
                                Console.WriteLine(load_Network_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:

                                Console.WriteLine(Network_S01.network_monitor());
                                Console.WriteLine(load_Network_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 3:

                                Console.WriteLine(Network_S01.network_monitor01());
                                Console.WriteLine(load_Network_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 4:
                                new Network_Main_View01();
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