using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.USER_VIEW.USER_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_USER_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.USER_MODEL;


namespace EASYPROJECT01.EASYCONSOLE.VIEW.USER_VIEW.USER_SELECTION_VIEW
{
    internal class User_Selection_View04
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        private static Sql_Manager01 Sql_M01 = new Sql_Manager01();
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        private static Location_Helper01 Location_H01 = new Location_Helper01();
        private static File_Picker01 File_P01 = new File_Picker01();
        private static User_Model01 User_M01 = new User_Model01();

        private bool stored_proccedure_bool = Sql_Serv01.view_user_database_storedprocedures(out data01[50]);
        public string[] stored_proccedure_array = data01[50].Split("\n");
        public User_Selection_View04()
        {
            load_User_Selection_View04();
        }

        private string load_User_Selection_View04_string()
        {

            string stored = string.Empty;

            if (stored_proccedure_bool == true)
            {
                for (int i = 0; i < stored_proccedure_array.Length; i++)
                {

                    stored += $"{i}.) {stored_proccedure_array[i]}\n";
                }
            }
            else
            {

                stored = data01[50];
                new User_Main_View01();
            }
            return $"{stored}";
        }
        private void load_User_Selection_View04()
        {
            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("username\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.delete_user_using_username(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("emailaddress\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.find_email_using_email(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("username\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.find_email_using_username(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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
                            case 4:

                                Console.WriteLine("emailaddress");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3], out data01[23]) == true)
                                    {
                                        if (Sql_Serv01.find_password_using_email(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 5:

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.find_password_using_username(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("emailaddress");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3], out data01[24]) == true)
                                    {

                                        if (Sql_Serv01.find_phonenumber_using_email(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("phonenumber");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.find_phonenumber_using_phonenumber(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {

                                        if (Sql_Serv01.find_phonenumber_using_username(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("emailaddress");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.find_user_location_using_email(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {

                                        if (Sql_Serv01.find_user_location_using_username(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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
                            case 11:

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Sql_Serv01.find_username_password(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View04_string());
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
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 12:

                                Console.WriteLine("emailaddress");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3], out data01[23]) == true)
                                    {
                                        if (Sql_Serv01.find_username_using_email(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
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
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 13:

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                                {

                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View04_string());
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
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 14:

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View04_string());
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
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 15:
                                Console.WriteLine("needs work");
                                Console.WriteLine(load_User_Selection_View04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 16:

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == false)
                                    {

                                        Console.WriteLine("firstname");
                                        data01[4] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[4], out data01[25]) == true)
                                        {

                                            Console.WriteLine("lastname");
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[5], out data01[26]) == true)
                                            {
                                                Console.WriteLine("date of birth");
                                                data01[6] = Console.ReadLine() ?? string.Empty;
                                                if (Security_Serv01.empty_string(data01[6], out data01[27]) == true)
                                                {
                                                    if (Security_Serv01.date_check(data01[6], out data01[28]) == true)
                                                    {


                                                        Console.WriteLine("email address");
                                                        data01[7] = Console.ReadLine() ?? string.Empty;
                                                        if (Security_Serv01.empty_string(data01[7], out data01[29]) == true)
                                                        {
                                                            if (Security_Serv01.email_check(data01[7], out data01[30]) == true)
                                                            {
                                                                Console.WriteLine("phonenumber");
                                                                data01[8] = Console.ReadLine() ?? string.Empty;
                                                                if (Security_Serv01.empty_string(data01[8], out data01[31]) == true)
                                                                {
                                                                    if (Security_Serv01.phone_check(data01[8], out data01[32]) == true)
                                                                    {
                                                                        Console.WriteLine("password");
                                                                        data01[9] = Console.ReadLine() ?? string.Empty;
                                                                        if (Security_Serv01.empty_string(data01[9], out data01[33]) == true)
                                                                        {
                                                                            if (Security_Serv01.password_check(data01[9], out data01[34]) == true)
                                                                            {

                                                                                if (Sql_Serv01.insert_user(data01[3], data01[4], data01[5], data01[6], data01[7], data01[8], data01[9], out data01[35]) == true)
                                                                                {
                                                                                    Console.WriteLine(data01[35]);
                                                                                    Console.WriteLine(load_User_Selection_View04_string());
                                                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                                                    break;
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine(data01[35]);
                                                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                                                    continue;
                                                                                }

                                                                            }
                                                                            else
                                                                            {

                                                                                Console.WriteLine(data01[34]);
                                                                                Console.WriteLine(load_User_Selection_View04_string());
                                                                                data01[9] = Console.ReadLine() ?? string.Empty;
                                                                                continue;

                                                                            }

                                                                        }
                                                                        else
                                                                        {

                                                                            Console.WriteLine(data01[33]);
                                                                            Console.WriteLine(load_User_Selection_View04_string());
                                                                            data01[9] = Console.ReadLine() ?? string.Empty;
                                                                            continue;

                                                                        }

                                                                    }
                                                                    else
                                                                    {

                                                                        Console.WriteLine(data01[32]);
                                                                        Console.WriteLine(load_User_Selection_View04_string());
                                                                        data01[8] = Console.ReadLine() ?? string.Empty;
                                                                        continue;
                                                                    }


                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine(data01[31]);
                                                                    Console.WriteLine(load_User_Selection_View04_string());
                                                                    data01[8] = Console.ReadLine() ?? string.Empty;
                                                                    continue;
                                                                }




                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine(data01[25]);
                                                                Console.WriteLine(load_User_Selection_View04_string());
                                                                data01[7] = Console.ReadLine() ?? string.Empty;
                                                                continue;

                                                            }


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine(data01[25]);
                                                            Console.WriteLine(load_User_Selection_View04_string());
                                                            data01[7] = Console.ReadLine() ?? string.Empty;
                                                            continue;
                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[27]);
                                                    data01[6] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[26]);
                                                Console.WriteLine(load_User_Selection_View04_string());
                                                data01[5] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }


                                        }
                                        else
                                        {

                                            Console.WriteLine("username already taken");
                                            data01[4] = Console.ReadLine() ?? string.Empty;
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
                                break;
                            case 17:
                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {
                                        if (File_P01.filepickerlinux01(out data01[25]))
                                        {
                                            if (Sql_Serv01.insert_user_audio_file_using_username(data01[3], data01[25], out data01[26]) == true)
                                            {
                                                Console.WriteLine(data01[26]);
                                                Console.WriteLine(load_User_Selection_View04_string());
                                                data01[3] = Console.ReadLine() ?? string.Empty;
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
                            case 18:
                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {
                                        if (File_P01.filepickerlinux01(out data01[25]))
                                        {
                                            if (Sql_Serv01.insert_user_audio_file_using_username(data01[3], data01[25], out data01[26]) == true)
                                            {
                                                Console.WriteLine(data01[26]);
                                                Console.WriteLine(load_User_Selection_View04_string());
                                                data01[3] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {

                                        if (File_P01.filepickerlinux01(out data01[25]))
                                        {
                                            if (Sql_Serv01.insert_user_text_file_using_username(data01[3], data01[26], out data01[25]) == true)
                                            {
                                                Console.WriteLine(data01[26]);
                                                Console.WriteLine(load_User_Selection_View04_string());
                                                data01[3] = Console.ReadLine() ?? string.Empty;
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


                            case 20:
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_email_using_email(data01[3], data01[4], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_email_using_username(data01[3], data01[4], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_password_using_email(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_password_using_phonenumber(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_password_using_username(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_phonenumber_using_email(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_phonenumber_using_username(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_user_location_using_email(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_user_location_using_name(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_user_location_using_phonenumber(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_user_location_using_username(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your email");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    Console.WriteLine("create new email");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.update_username_using_email(data01[4], data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your phonenumber");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Security_Serv01.phone_check(data01[3], out data01[24]) == true)
                                    {

                                        if (Sql_Serv01.find_phonenumber_using_phonenumber(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine("create new username");
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                            {

                                                if (Sql_Serv01.update_username_using_phonenumber(data01[3], data01[4], out data01[25]) == true)
                                                {
                                                    Console.WriteLine(data01[25]);
                                                    Console.WriteLine(load_User_Selection_View04_string());
                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[25]);
                                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                                    continue;

                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[24]);
                                                data01[4] = Console.ReadLine() ?? string.Empty;
                                                continue;

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[24]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine("your username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == true)
                                    {
                                        Console.WriteLine("create new username");
                                        data01[4] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[4], out data01[25]) == true)
                                        {
                                            if (Sql_Serv01.find_username_using_username(data01[4], out data01[26]) == false)
                                            {
                                                if (Sql_Serv01.update_username_using_username(data01[4], data01[3], out data01[26]) == true)
                                                {
                                                    Console.WriteLine(data01[26]);
                                                    Console.WriteLine(load_User_Selection_View04_string());
                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[26]);
                                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                                    continue;

                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[24]);
                                                data01[4] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
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
                                break;
                            case 34:
                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    Console.WriteLine("password");
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[4], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.user_login(data01[3], data01[4], out data01[25]) == true)
                                        {
                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View04_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[4] = Console.ReadLine() ?? string.Empty;
                                            continue;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[4] = Console.ReadLine() ?? string.Empty;
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
                                Console.WriteLine(Sql_Serv01.view_all_email());
                                Console.WriteLine(load_User_Selection_View04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;

                            case 36:
                                //     Console.WriteLine(Sql_Serv01.view_all_passwords());
                                Console.WriteLine(load_User_Selection_View04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 37:
                                Console.WriteLine(Sql_Serv01.view_all_phonenumber());
                                Console.WriteLine(load_User_Selection_View04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 38:
                                Console.WriteLine(Sql_Serv01.view_all_username());
                                Console.WriteLine(load_User_Selection_View04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 39:
                                if (Sql_Serv01.view_user_database_storedprocedures(out data01[23]) == true)
                                {
                                    Console.WriteLine(data01[23]);
                                    Console.WriteLine(load_User_Selection_View04_string());
                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    Console.WriteLine(load_User_Selection_View04_string());
                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                    break;
                                }
                            case 40:

                                Console.WriteLine("username");
                                data01[3] = User_M01.random_username;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[24]) == false)
                                    {

                                        Console.WriteLine("firstname");
                                        data01[4] = User_M01.random_first_name;
                                        if (Security_Serv01.empty_string(data01[4], out data01[25]) == true)
                                        {

                                            Console.WriteLine("lastname");
                                            data01[5] = User_M01.random_last_name;
                                            if (Security_Serv01.empty_string(data01[5], out data01[26]) == true)
                                            {
                                                Console.WriteLine("date of birth");
                                                data01[6] = User_M01.random_birthdays;
                                                if (Security_Serv01.empty_string(data01[6], out data01[27]) == true)
                                                {
                                                    if (Security_Serv01.date_check(data01[6], out data01[28]) == true)
                                                    {


                                                        Console.WriteLine("email address");
                                                        data01[7] = User_M01.random_birthdays;
                                                        if (Security_Serv01.empty_string(data01[7], out data01[29]) == true)
                                                        {
                                                            if (Security_Serv01.email_check(data01[7], out data01[30]) == true)
                                                            {
                                                                Console.WriteLine("phonenumber");
                                                                data01[8] = User_M01.random_phone_numbers;
                                                                if (Security_Serv01.empty_string(data01[8], out data01[31]) == true)
                                                                {
                                                                    if (Security_Serv01.phone_check(data01[8], out data01[32]) == true)
                                                                    {
                                                                        Console.WriteLine("password");
                                                                        data01[9] = User_M01.random_passwords;
                                                                        if (Security_Serv01.empty_string(data01[9], out data01[33]) == true)
                                                                        {
                                                                            if (Security_Serv01.password_check(data01[9], out data01[34]) == true)
                                                                            {

                                                                                if (Sql_Serv01.insert_user(data01[3], data01[4], data01[5], data01[6], data01[7], data01[8], data01[9], out data01[35]) == true)
                                                                                {
                                                                                    Console.WriteLine(data01[35]);
                                                                                    Console.WriteLine(load_User_Selection_View04_string());
                                                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                                                    break;
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine(data01[35]);
                                                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                                                    continue;
                                                                                }

                                                                            }
                                                                            else
                                                                            {

                                                                                Console.WriteLine(data01[34]);
                                                                                Console.WriteLine(load_User_Selection_View04_string());
                                                                                data01[9] = Console.ReadLine() ?? string.Empty;
                                                                                continue;

                                                                            }

                                                                        }
                                                                        else
                                                                        {

                                                                            Console.WriteLine(data01[33]);
                                                                            Console.WriteLine(load_User_Selection_View04_string());
                                                                            data01[9] = Console.ReadLine() ?? string.Empty;
                                                                            continue;

                                                                        }

                                                                    }
                                                                    else
                                                                    {

                                                                        Console.WriteLine(data01[32]);
                                                                        Console.WriteLine(load_User_Selection_View04_string());
                                                                        data01[8] = Console.ReadLine() ?? string.Empty;
                                                                        continue;
                                                                    }


                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine(data01[31]);
                                                                    Console.WriteLine(load_User_Selection_View04_string());
                                                                    data01[8] = Console.ReadLine() ?? string.Empty;
                                                                    continue;
                                                                }




                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine(data01[25]);
                                                                Console.WriteLine(load_User_Selection_View04_string());
                                                                data01[7] = Console.ReadLine() ?? string.Empty;
                                                                continue;

                                                            }


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine(data01[25]);
                                                            Console.WriteLine(load_User_Selection_View04_string());
                                                            data01[7] = Console.ReadLine() ?? string.Empty;
                                                            continue;
                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[27]);
                                                    data01[6] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[26]);
                                                Console.WriteLine(load_User_Selection_View04_string());
                                                data01[5] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }


                                        }
                                        else
                                        {

                                            Console.WriteLine("username already taken");
                                            data01[4] = Console.ReadLine() ?? string.Empty;
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
                                break;

                            case 41:
                                new User_Main_View01();
                                break;
                            default:
                                Console.WriteLine(load_User_Selection_View04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
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