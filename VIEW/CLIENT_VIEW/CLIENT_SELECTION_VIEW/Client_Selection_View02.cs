using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES;
using EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_SELECTION_VIEW
{
    internal class Client_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();
        private static Sql_Client_Services02 Sql_Client_S02 = new Sql_Client_Services02();
        private string resaults = string.Empty;
        public Client_Selection_View02()
        {
            load_Client_Selection_View02();
        }
        private string load_Client_Selection_View02_String()
        {
            return     $"1.)find_client_address_by_email\n"+
                    $"2.) go back\n";


        }
        private void load_Client_Selection_View02()
        {
            Console.WriteLine(load_Client_Selection_View02_String());
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
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.delete_client_using_email(data01[3],out data01[25]) == true)
                                        {
                                              Console.WriteLine(data01[25]);
                                             Console.WriteLine(load_Client_Selection_View02_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
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
            
                            case 2:
                            new Client_View01();
                                break;
                        }
                    }
                }
            }
        }
    }
}
