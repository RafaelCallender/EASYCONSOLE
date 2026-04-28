using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES;
using EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_SELECTION_VIEW
{
    internal class Client_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();
        private static Sql_Client_Services02 Sql_Client_S02 = new Sql_Client_Services02();
        private string resaults = string.Empty;
        public Client_Selection_View01()
        {
            load_Client_Selection_View01();
        }
        private string load_Client_Selection_View01_String()
        {
            return     $"1.) delete_client_using_email\n" +
                $"2.) delete_client_using_name\n" +
                $"3.) find_client_email_by_email\n" +
                $"4.) find_client_email_by_name\n" +
                $"5.) find_client_email_by_phonenumber\n" +
                $"6.) find_client_name_by_email\n" +
                $"7.) find_client_name_by_name\n" +
                $"8.) find_client_name_by_phonenumber\n" +
                $"9.) find_client_phonenumber_by_email\n" +
                $"10.) find_client_phonenumber_by_name\n" +
                $"11.) find_client_phonenumber_by_phonenumber\n" +
                $"12.) insert_client\n" +
                $"13.) update_clients_email_using_email\n" +
                $"14.) update_clients_email_using_name\n" +
                $"15.) update_clients_email_using_phonenumber\n" +
                $"16.) update_clients_name_using_email\n" +
                $"17.) update_clients_name_using_name\n" +
                $"18.) update_clients_name_using_phonenumber\n" +
                $"19.) update_clients_phonenumber_using_email\n" +
                $"20.) update_clients_phonenumber_using_name\n" +
                $"21.) update_clients_phonenumber_using_phonenumber\n" +
                $"22.) find_client_emailkey_by_name\n" +
                $"23.) insert_user01\n" +
                $"24.) delete_user_using_email\n" +
                $"25.) delete_user_using_name\n" +
                $"26.) delete_user_using_phonenumber\n" +
                $"27.) find_user_email_by_email\n" +
                $"28.) find_user_email_by_name\n" +
                $"29.) find_user_email_by_phonenumber\n" +
                $"30.) find_user_name_by_email\n" +
                $"31.) find_user_name_by_name\n" +
                $"32.) find_user_name_by_phonenumber\n" +
                $"33.) find_user_phonenumber_by_email\n" +
                $"34.) find_user_phonenumber_by_name\n" +
                $"35.) find_user_phonenumber_by_phonenumber\n" +
                $"36.) find_user_message_by_name\n" +
                $"37.) find_user_message_by_email\n" +
                $"38.) find_user_message_by_phonenumber\n" +
                $"39.) find_user_name_by_email_by_name\n" +
                $"40.) find_client_cashapp_by_name\n" +
                $"41.) find_client_cashapp_by_phonenumber\n" +
                $"42.) find_client_cashapp_by_email\n" +
                $"43.) find_client_zelle_by_email\n" +
                $"44.) find_client_zelle_by_name\n" +
                $"45.) find_client_zelle_by_phonenumber\n" +
                $"46.) find_client_paypal_by_email\n" +
                $"47.) find_client_paypal_by_phonenumber\n" +
                $"48.) find_client_paypal_using_name\n" +
                $"49.) find_client_venmo_by_phonenumber\n" +
                $"50.) find_client_venmo_by_number\n" +
                $"51.) find_client_venmo_by_email\n" +
                $"52.) find_client_venmo_by_name\n" +
                $"54.) go back\n";


        }
        private void load_Client_Selection_View01()
        {
            Console.WriteLine(load_Client_Selection_View01_String());
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
                                             Console.WriteLine(load_Client_Selection_View01_String());
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
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                

                                        if (Sql_Client_S01.delete_client_using_name(data01[3], out data01[24]) == true)
                                        {
                                           
                                            Console.WriteLine(data01[24]);
                                                 Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                             Console.WriteLine(data01[24]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;
                                        }
                          

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;
                                }
                            case 3:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_email_by_email(data01[3],out data01[25]) == true)
                                        {
                                         Console.WriteLine(data01[25]);
                                             Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;
                                        }
                                    }
                                    else
                                    {
                                      Console.WriteLine(data01[24]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;
                                    }

                                }
                                else
                                {
                              Console.WriteLine(data01[23]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;
                                }
                            case 4:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                               

                                        if (Sql_Client_S01.find_client_email_by_name(data01[3], out data01[24]) == true)
                                        {
                                       
                                            Console.WriteLine(data01[24]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                              Console.WriteLine(data01[24]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;
                                        }
                                    

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            return;
                                }
                            case 5:
                                data01[2] = $"client phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3], out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_email_by_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                          
                                            Console.WriteLine(data01[25]);
                                               Console.WriteLine(load_Client_Selection_View01_String());
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
                                      
                                        Console.WriteLine(data01[25]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                              
                                    Console.WriteLine(data01[25]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 6:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_name_by_email(data01[3],out data01[25]) == true)
                                        {
                                         
                                            Console.WriteLine(data01[25]);
                                                  Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 7:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S01.find_client_name_by_name(data01[3], out data01[24]) == true)
                                    {
                                      
                                        Console.WriteLine(data01[24]);
                                               Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 8:
                                data01[2] = $"client phoneumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_name_by_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 9:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_phonenumber_by_email(data01[3],out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                    Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 10:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S01.find_client_phonenumber_by_name(data01[3], out data01[24]) == true)
                                    {
                                     
                                        Console.WriteLine(data01[24]);
                                               Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 11:
                                data01[2] = $"client phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_phonenumber_by_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                      
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 12:
                                data01[2] = $"insert client:\n" +
                                             $"Client name:\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {

                                    data01[2] = $"client_email_key:\n";

                                    if (Sql_Client_S01.insert_client(data01[41], data01[42], data01[43], data01[44], data01[45], data01[46], data01[47], data01[48], data01[48],
                                    out resaults) == true)
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
                                              Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                    }
                                    else
                                    {
                                        data01[22] = resaults;
                                        Console.WriteLine(data01[22]);
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
                            case 13:

                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {

                                    data01[2] = $"make new email address\n";
                                    Console.WriteLine(data01[2]);
                                    data01[4] = Console.ReadLine() ?? string.Empty;

                                    if (Security_Serv01.empty_string(data01[4],out data01[24]) == true)
                                    {
                                        if (Security_Serv01.email_check(data01[4],out data01[25]) == true)
                                        {
                                            if (Sql_Client_S01.update_clients_email_using_name(data01[3], data01[4], out data01[26]) == true)
                                            {
                                                data01[22] = resaults;
                                                Console.WriteLine(data01[26]);
                                                          Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                            }
                                            else
                                            {
                                                data01[22] = resaults;
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
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



                            case 14:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {

                                    data01[2] = $"make new email address\n";
                                    Console.WriteLine(data01[2]);
                                    data01[4] = Console.ReadLine() ?? string.Empty;

                                    if (Security_Serv01.empty_string(data01[4],out data01[24]) == true)
                                    {
                                        if (Security_Serv01.email_check(data01[4],out data01[25]) == true)
                                        {
                                            if (Sql_Client_S01.update_clients_email_using_name(data01[3], data01[4], out data01[26]) == true)
                                            {
                                              
                                                Console.WriteLine(data01[26]);
                                                          Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                            }
                                            else
                                            {
                                                data01[22] = resaults;
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
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
                            case 15:
                                data01[2] = $"client phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {
                                        data01[2] = $"make new email address\n";
                                        Console.WriteLine(data01[2]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;

                                        if (Security_Serv01.empty_string(data01[4],out data01[25]) == true)
                                        {
                                            if (Security_Serv01.email_check(data01[4], out data01[26]) == true)
                                            {
                                                if (Sql_Client_S01.update_clients_email_using_phonenumber(data01[3], data01[4], out data01[27]) == true)
                                                {
                                                    
                                                    Console.WriteLine(data01[27]);
                                                           Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                                }
                                                else
                                                {
                                                  
                                                    Console.WriteLine(data01[27]);
                                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                              
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
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
                            case 16:
                                data01[2] = $"client email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3], out data01[24]) == true)
                                    {
                                        data01[2] = $"make new name\n";
                                        Console.WriteLine(data01[2]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;

                                        if (Security_Serv01.empty_string(data01[4],out data01[25]) == true)
                                        {

                                            if (Sql_Client_S01.update_clients_name_using_email(data01[3], data01[4], out data01[26]) == true)
                                            {
                                            
                                                Console.WriteLine(data01[26]);
                                                      Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                            }
                                            else
                                            {
                                           
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }

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
                            case 17:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {

                                    data01[2] = $"make new name\n";
                                    Console.WriteLine(data01[2]);
                                    data01[4] = Console.ReadLine() ?? string.Empty;

                                    if (Security_Serv01.empty_string(data01[4],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.update_clients_name_using_name(data01[3], data01[4], out data01[25]) == true)
                                        {
                                       
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 18:
                                data01[2] = $"client phoneumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {
                                        data01[2] = $"make new name\n";
                                        Console.WriteLine(data01[2]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;

                                        if (Security_Serv01.empty_string(data01[4],out data01[25]) == true)
                                        {

                                            if (Sql_Client_S01.update_clients_name_using_phonenumber(data01[3], data01[4], out data01[26]) == true)
                                            {
                                              
                                                Console.WriteLine(data01[26]);
                                                        Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                            }
                                            else
                                            {
                                            
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }

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
                            case 19:
                                data01[2] = $"client email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {
                                        data01[2] = $"make new phonenumber\n";
                                        Console.WriteLine(data01[2]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;

                                        if (Security_Serv01.empty_string(data01[4],out data01[25]) == true)
                                        {
                                            if (Security_Serv01.phone_check(data01[4],out data01[26]) == true)
                                            {
                                                if (Sql_Client_S01.update_clients_phonenumber_using_email(data01[3], data01[4], out data01[27]) == true)
                                                {
                                                 
                                                    Console.WriteLine(data01[27]);
                                                           Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                                }
                                                else
                                                {
                                                
                                                    Console.WriteLine(data01[27]);
                                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                              
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
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
                            case 20:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {

                                    data01[2] = $"make new phonenumber\n";
                                    Console.WriteLine(data01[2]);
                                    data01[4] = Console.ReadLine() ?? string.Empty;

                                    if (Security_Serv01.empty_string(data01[4],out data01[24]) == true)
                                    {
                                        if (Security_Serv01.phone_check(data01[4],out data01[25]) == true)
                                        {
                                            if (Sql_Client_S01.update_clients_phonenumber_using_name(data01[3], data01[4], out data01[26]) == true)
                                            {
                                               
                                                Console.WriteLine(data01[26]);
                                                       Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                            }
                                            else
                                            {
                                              
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
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
                            case 21:
                                data01[2] = $"client phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {
                                        data01[2] = $"make new phonenumber\n";
                                        Console.WriteLine(data01[2]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;

                                        if (Security_Serv01.empty_string(data01[4],out data01[25]) == true)
                                        {
                                            if (Security_Serv01.phone_check(data01[4],out data01[26]) == true)
                                            {
                                                if (Sql_Client_S01.update_clients_phonenumber_using_phonenumber(data01[3], data01[4], out data01[27]) == true)
                                                {
                                                 
                                                    Console.WriteLine(data01[27]);
                                                          Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                                }
                                                else
                                                {
                                                   
                                                    Console.WriteLine(data01[27]);
                                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                            
                                                Console.WriteLine(data01[26]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
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
                            case 22:
                                data01[2] = $"clients name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S01.find_client_emailkey_by_name(data01[3], out data01[24]) == true)
                                    {
                                       
                                        Console.WriteLine(data01[24]);
                                               Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 23:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                            {
                                if (Security_Serv01.email_check(data01[3],out data01[23]) == true)
                                    {

                                    if (Sql_Client_S02.insert_user01(data01[41], data01[42], data01[43], data01[44], out data01[24]) == true)
                                    {

                                        Console.WriteLine(data01[24]);
                                                 Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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




                            }
                            else
                            {

                                Console.WriteLine(data01[23]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                continue;
                            }
                            case 24:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.delete_user_using_email(data01[3], out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                    Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 25:
                                data01[2] = $"user name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S02.delete_user_using_name(data01[3],out data01[24]) == true)
                                    {
                                       
                                        Console.WriteLine(data01[24]);
                                                  Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 26:
                                data01[2] = $"user phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.delete_user_using_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                           
                                            Console.WriteLine(data01[25]);
                                                    Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 27:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.find_user_email_by_email(data01[3], out data01[25]) == true)
                                        {
                                           
                                            Console.WriteLine(data01[25]);
                                                     Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 28:
                                data01[2] = $"user name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S02.find_user_email_by_name(data01[3], out data01[24]) == true)
                                    {
                                      
                                        Console.WriteLine(data01[24]);
                                                  Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 29:
                                data01[2] = $"user phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3], out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.find_user_email_by_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                           
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 30:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {


                                
                                        Console.WriteLine(data01[24]);
                               Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
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
                            case 31:
                                data01[2] = $"user name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S02.find_user_name_by_name(data01[3], out data01[24]) == true)
                                    {
                                       
                                        Console.WriteLine(data01[24]);
                                            Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 32:
                                data01[2] = $"user phoneumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.find_user_name_by_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 33:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.find_user_phonenumber_by_email(data01[3], out data01[25]) == true)
                                        {
                                         
                                            Console.WriteLine(data01[25]);
                                                     Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 34:
                                data01[2] = $"user name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S02.find_user_phonenumber_by_name(data01[3], out data01[24]) == true)
                                    {
                                        
                                        Console.WriteLine(data01[24]);
                                                 Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 35:
                                data01[2] = $"user phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.find_user_phonenumber_by_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                  Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 36:
                                data01[2] = $"user name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {


                                    if (Sql_Client_S02.find_user_message_by_name(data01[3], out data01[24]) == true)
                                    {
                                       
                                        Console.WriteLine(data01[24]);
                                              Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 37:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.find_user_message_by_email(data01[3],out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                     Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 38:
                                data01[2] = $"user phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S02.find_user_message_by_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                  Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 39:
                                data01[2] = $"user name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S02.find_user_name_by_email_by_name(data01[3],out data01[24]) == true)
                                    {
                                       
                                        Console.WriteLine(data01[24]);
                                              Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 40:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S01.find_client_cashapp_by_name(data01[3], out data01[24]) == true)
                                    {
                                       
                                        Console.WriteLine(data01[24]);
                                                Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 41:
                                data01[2] = $"client phoneumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_cashapp_by_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                           
                                            Console.WriteLine(data01[25]);
                                                  Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 42:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_cashapp_by_email(data01[3],out data01[25]) == true)
                                        {
                                           
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 44:
                                data01[2] = $"client email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_zelle_by_email(data01[3],out data01[25]) == true)
                                        {
                                          
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 45:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S01.find_client_zelle_by_name(data01[3],out data01[24]) == true)
                                    {
                                    
                                        Console.WriteLine(data01[24]);
                                               Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 46:
                                data01[2] = $"client phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_zelle_by_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                          
                                            Console.WriteLine(data01[25]);
                                                 Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 47:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_paypal_by_email(data01[3],out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                      Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 48:
                                data01[2] = $"client phoneumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_paypal_by_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                           
                                            Console.WriteLine(data01[25]);
                                                    Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 49:
                                data01[2] = $"client name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S01.find_client_paypal_using_name(data01[3],out data01[24]) == true)
                                    {
                                      
                                        Console.WriteLine(data01[24]);
                                                  Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 50:
                                data01[2] = $"client phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_venmo_by_phonenumber(data01[3],out data01[25]) == true)
                                        {
                                         
                                            Console.WriteLine(data01[25]);
                                                    Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 51:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_venmo_by_email(data01[3],out data01[25]) == true)
                                        {
                                          
                                            Console.WriteLine(data01[25]);
                                                    Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 52:
                                data01[2] = $"email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {

                                        if (Sql_Client_S01.find_client_venmo_by_email(data01[3],out data01[25]) == true)
                                        {
                                            
                                            Console.WriteLine(data01[25]);
                                                   Console.WriteLine(load_Client_Selection_View01_String());
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
                            case 53:
                                data01[2] = $"client name \n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {


                                    if (Sql_Client_S01.find_client_venmo_by_name(data01[3],out data01[24]) == true)
                                    {
                                     
                                        Console.WriteLine(data01[24]);
                                                 Console.WriteLine(load_Client_Selection_View01_String());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

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
                            case 54:
                                return;
                        }
                    }
                }
            }
        }
    }
}
