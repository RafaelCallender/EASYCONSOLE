using EASY_CALLENDER01.MODEL.USER_MODEL.TEST_MODEL.TEST_GET_MODEL;
using EASY_CALLENDER01.SERVICES.CALENDAR_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_EMIAL_SERVICES;
using EASY_CALLENDER01.SERVICES.EMAIL_SERVICES;
using System.Reflection.Metadata.Ecma335;
using EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_MYEMIAL_SERVICES;

namespace EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW
{
    internal class Email_Selection_View03
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_S01 = new Security_Services01();
        private static Email_Services01 Email_S01 = new Email_Services01();
        private static MySql_Email_Services01 MySql_Email_S01 = new MySql_Email_Services01();
        private static DateTime dt = DateTime.Now;
        private static string dtstring = dt.ToString("yyyy-dd-MM");
        private static string[] res01 = new string[100];
        public Email_Selection_View03()
        {
            load_Email_View03();
        }
        private string load_Email_View03_String()
        {
            return $"1.) insert_email\n" +
                $"2.) find_email_using_email\n" +
                $"3.) find_email_using_name\n" +
                $"4.) find_email_using_phonenumber\n" +
                $"5.) find_full_name_using_email\n" +
                $"6.) find_full_name_using_full_name\n" +
                $"7.) find_full_name_using_phonenumber\n" +
                $"8.) find_phonenumber_using_email\n" +
                $"9.) find_phonenumber_using_fullname\n" +
                $"10.) find_phonenumber_using_phonenumber\n";
        } 
        private void load_Email_View03()
        {

  
            Console.WriteLine(load_Email_View03_String());
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {

                if (Security_S01.empty_string(data01[1],out data01[23]) == true)
                {
                    if (Security_S01.string_only_digit(data01[1],out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                                data01[2] = "Email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if(Security_S01.empty_string(data01[3], out data01[25]) == true)	
                                {
                                    if (Security_S01.email_check(data01[3],out data01[26]) == true)
                                    {
                                        data01[4] = "Name\n";
                                        Console.WriteLine(data01[4]);
                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                        if (Security_S01.empty_string(data01[5],out data01[27]) == true)
                                        {

                                            data01[4] = "Phonenumber\n";
                                            Console.WriteLine(data01[4]);
                                            data01[6] = Console.ReadLine() ?? string.Empty;
                                            if (Security_S01.empty_string(data01[6],out data01[28]) == true)
                                            {
                                                if (Security_S01.phone_check(data01[6],out data01[29]) == true)
                                                {

                                                    data01[7] = "Message\n";
                                                    Console.WriteLine(data01[7]);
                                                    data01[8] = Console.ReadLine() ?? string.Empty;
                                                    if (Security_S01.empty_string(data01[8],out data01[30]) == true)
                                                    {



                                                        if (Email_S01.send_email(data01[3], data01[5], data01[6], data01[7], out data01[31]) == true)
                                                        {


                                                            if (MySql_Email_S01.insert_email(data01[5], data01[3], dtstring, data01[6], data01[8], out data01[32]) == true)
                                                            {


                                                        
                                                                Console.WriteLine(data01[32]);
                                                                data01[8] = Console.ReadLine() ?? string.Empty;
                                                                return;

                                                            }
                                                            else
                                                            {



                                                                Console.WriteLine(data01[32]);
                                                                data01[8] = Console.ReadLine() ?? string.Empty;
                                                                continue;
                                                            }

                                                        }
                                                        else
                                                        {
                                                   
                                                            Console.WriteLine(data01[31]);
                                                            data01[8] = Console.ReadLine() ?? string.Empty;
                                                            continue;
                                                        }

                                                    }
                                                    else
                                                    {
                                                
                                                        Console.WriteLine(data01[30]);
                                                        data01[8] = Console.ReadLine() ?? string.Empty;
                                                        continue;

                                                    }

                                                }
                                                else
                                                {
                                                   
                                                    Console.WriteLine(data01[29]);
                                                    data01[6] = Console.ReadLine() ?? string.Empty;
                                                    continue;

                                                }



                                            }
                                            else
                                            {
                                            
                                                Console.WriteLine(data01[28]);
                                                data01[6] = Console.ReadLine() ?? string.Empty;
                                                continue;

                                            }

                                        }
                                        else
                                        {
                                           
                                            Console.WriteLine(data01[27]);
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                              
                                        Console.WriteLine(data01[22]);
                                        data01[5] = Console.ReadLine() ?? string.Empty;
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

                                data01[2] = "Email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_email_using_email(data01[3],out data01[24]) == true)
                                    {
                                        data01[4] =data01[24];
                                        return;

                                    }
                                    else
                                    {
                                        data01[4] = data01[24];
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

                                data01[2] = "Name \n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_email_using_name(data01[3],out data01[24]) == true)
                                    {
                                       
Console.WriteLine(data01[24]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    return;
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
                            
                            case 4:

                                data01[2] = "Phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_email_using_phonenumber(data01[3], out data01[24]) == true)
                                    {
                                               Console.WriteLine(data01[24]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    return;
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
                       
                            case 5:

                                data01[2] = "Email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_full_name_using_email(data01[3],out data01[24]) == true)
                                    {
                                         Console.WriteLine(data01[24]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                               return;
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
                                
                            case 6:

                                data01[2] = "Name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_full_name_using_full_name(data01[3],out data01[24]) == true)
                                    {
                                       Console.WriteLine(data01[24]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    return;
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

                                data01[2] = "Phonenumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_full_name_using_phonenumber(data01[3],out data01[24]) == true)
                                    {
                                    Console.WriteLine(data01[24]);
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
                        
                            case 8:

                                data01[2] = "Email address\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_phonenumber_using_email(data01[3], out res01[0]) == true)
                                    {
                                        data01[4] = res01[0];
                                        return ;    

                                    }
                                    else
                                    {
                                        data01[4] = res01[0];
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

                                data01[2] = "Name\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_phonenumber_using_fullname(data01[3], out res01[0]) == true)
                                    {
                                        data01[4] = res01[0];
                                        return;
                                    }
                                    else
                                    {
                                        data01[4] = res01[0];
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

                                data01[2] = "Phoneumber\n";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                               if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (MySql_Email_S01.find_phonenumber_using_phonenumber(data01[3], out res01[0]) == true)
                                    {
                                        data01[4] = res01[0];
                                        return ;    
                                    }
                                    else
                                    {
                                        data01[4] = res01[0];
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
					}
				}
			}
		}
	}
}