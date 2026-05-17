using EASY_CALLENDER01.MODEL.USER_MODEL.TEST_MODEL.TEST_GET_MODEL;
using EASY_CALLENDER01.SERVICES.CALENDAR_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_EMIAL_SERVICES;
using EASY_CALLENDER01.SERVICES.EMAIL_SERVICES;
using System.Reflection.Metadata.Ecma335;
using EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_EMAIL_SERVICES;
using EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_MANAGER.SQLITE_EMAIL_MANAGER;
using EASY_CALLENDER01.MODEL.SQL_MODEL.SQLITE_MODEL.SQL_CHEMISTRY_MODEL.SQLITE_CHEMISTRY_GET_MODEL;
namespace EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW
{
    internal class Email_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_S01 = new Security_Services01();
        private static Email_Services01 Email_S01 = new Email_Services01();
        private static Sqlite_Email_Services01 Sqlite_Email_S01 = new Sqlite_Email_Services01();
        

        public Email_Selection_View02() 
        {
            load_Email_View02();
            
        }

        private string load_Email_View02_string()
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
                $"10.) find_phonenumber_using_phonenumber\n"+
                $"11.) back\n";
        }

        private void load_Email_View02()
        {


            Console.WriteLine(load_Email_View02_string());
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {

                if (Security_S01.empty_string(data01[1], out data01[23]) == true)
                {
                    if (Security_S01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:

                                Console.WriteLine("full name\n");
                                data01[2] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[2], out data01[25]) == true)
                                {



                                    Console.WriteLine("Email Addresss\n");
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    if (Security_S01.empty_string(data01[3], out data01[27]) == true)
                                    {
                                        if (Security_S01.email_check(data01[3], out data01[26]) == true)
                                        {



                                            Console.WriteLine("Phonenumber\n");
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            if (Security_S01.empty_string(data01[4], out data01[28]) == true)
                                            {
                                                if (Security_S01.phone_check(data01[4], out data01[29]) == true)
                                                {



                                                    Console.WriteLine("Message\n");
                                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                                    if (Security_S01.empty_string(data01[5], out data01[30]) == true)
                                                    {



                                                        if (Email_S01.send_email(data01[2], data01[3], data01[4], data01[5], out data01[31]) == true)
                                                        {


                                                            if (Sqlite_Email_S01.insert_email(data01[2], data01[3], data01[4], data01[5], out data01[32]) == true)
                                                            {



                                                                Console.WriteLine(

                                                                    $"{data01[31]}\n" +
                                                                    $"{data01[32]}\n"


                                                                );

                                                                Console.WriteLine(load_Email_View02_string());
                                                                data01[1] = Console.ReadLine() ?? string.Empty;
                                                                break;

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
                                                    Console.WriteLine(data01[28]);
                                                    data01[6] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[26]);
                                                data01[5] = Console.ReadLine() ?? string.Empty;
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
                                        Console.WriteLine(data01[25]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }
                                }

                                break;
                            case 2:

                        
                                Console.WriteLine("Email address\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_S01.email_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sqlite_Email_S01.find_email_using_email(data01[3], out data01[25]) == true)
                                        {


                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_Email_View02_string());
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


                            case 3:

                            
                                Console.WriteLine("Name\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sqlite_Email_S01.find_email_using_name(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine(data01[24]);
                                        Console.WriteLine(load_Email_View02_string());
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

                            case 4:

                            
                                Console.WriteLine("Phonenumber\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_S01.phone_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sqlite_Email_S01.find_email_using_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_Email_View02_string());
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

                            case 5:

                            
                                Console.WriteLine("Email address\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_S01.email_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sqlite_Email_S01.find_full_name_using_email(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_Email_View02_string());
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

                            case 6:

                                
                                Console.WriteLine("Name\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sqlite_Email_S01.find_full_name_using_full_name(data01[3], out data01[24]) == true)
                                    {
                                        Console.WriteLine(data01[24]);
                                        Console.WriteLine(load_Email_View02_string());
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

                            case 7:

                                
                                Console.WriteLine("Phonenumber\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_S01.phone_check(data01[3], out data01[24]) == true)
                                    {


                                        if (Sqlite_Email_S01.find_full_name_using_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_Email_View02_string());
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

                            case 8:

                            
                                Console.WriteLine("Email address\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_S01.email_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sqlite_Email_S01.find_phonenumber_using_email(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_Email_View02_string());
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

                            
                                Console.WriteLine("Name\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sqlite_Email_S01.find_phonenumber_using_fullname(data01[3], out data01[24]) == true)
                                    {
                                        Console.WriteLine(data01[24]);
                                        Console.WriteLine(load_Email_View02_string());
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

                            case 10:

                                
                                Console.WriteLine("Phoneumber\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_S01.phone_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sqlite_Email_S01.find_phonenumber_using_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_Email_View02_string());
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
                                new Email_Main_View01();
                                break;
                        }
                    }
                }
            }
        }
    }
}