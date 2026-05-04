using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.USER_VIEW.USER_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES;
using EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;

namespace EASYCONSOLE.VIEW.USER_VIEW.USER_SELECTION_VIEW
{
    internal class User_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        private static Location_Helper01 Location_H01 = new Location_Helper01();
        public User_Selection_View01()
        {
            load_User_Selection_View01();
        }


        private string load_User_Selection_View01_string()
        {
            int count = 0;
            string stored = string.Empty;
            if (Sql_Serv01.view_user_database_storedprocedures(out data01[20]) == true)
            {
                foreach (var a in data01[20].Split("\n"))
                {
                    count++;
                    stored += $"{count}.) {a}\n";
                }
                return $"{stored}{count}.)back";


            }
            else
            {
                return data01[20];
            }
        }
        private void load_User_Selection_View01()
        {


            Console.WriteLine(load_User_Selection_View01_string());
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

                                    if (Sql_Serv01.delete_user_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                                            Console.WriteLine(load_User_Selection_View01_string());
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

                                    if (Sql_Serv01.find_email_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                                            Console.WriteLine(load_User_Selection_View01_string());
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

                                    if (Sql_Serv01.find_password_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                                            Console.WriteLine(load_User_Selection_View01_string());
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

                                Console.WriteLine("emailaddress");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.phone_check(data01[3], out data01[24]) == true)
                                    {
                                        if (Sql_Serv01.find_phonenumber_using_phonenumber(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(data01[25]);
                                            Console.WriteLine(load_User_Selection_View01_string());
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

                                    if (Sql_Serv01.find_phonenumber_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                                            Console.WriteLine(load_User_Selection_View01_string());
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

                                    if (Sql_Serv01.find_user_location_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                            case 11:

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Sql_Serv01.find_username_password(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                                            Console.WriteLine(load_User_Selection_View01_string());
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
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                                        Console.WriteLine(load_User_Selection_View01_string());
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
                                Console.WriteLine(load_User_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 16:

                                Console.WriteLine("username");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (Sql_Serv01.find_username_using_username(data01[3], out data01[25]) == false)
                                    {


                                        Console.WriteLine("firstname");
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                        {

                                            Console.WriteLine("lastname");
                                            data01[3] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                            {
                                                Console.WriteLine("date of birth");
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                                {
                                                    if (Security_Serv01.date_check(data01[3], out data01[23]) == true)
                                                    {
                                                        Console.WriteLine("email address");
                                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                                        if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                                        {
                                                            if (Security_Serv01.email_check(data01[3], out data01[23]) == true)
                                                            {
                                                                Console.WriteLine("phonenumber");
                                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                                                {
                                                                    if (Security_Serv01.phone_check(data01[3], out data01[23]) == true)
                                                                    {
                                                                        Console.WriteLine("password");
                                                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                                                        if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                                                        {
                                                                            if (Security_Serv01.password_check(data01[3], out data01[23]) == true)
                                                                            {

                                                                                if (Sql_Serv01.insert_user(data01[1], data01[1], data01[1], data01[1], data01[1], data01[1], data01[1], out data01[1]) == true)

                                                                                {
                                                                                    Console.WriteLine(data01[25]);
                                                                                    Console.WriteLine(load_User_Selection_View01_string());
                                                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                                                    continue;
                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine(data01[25]);
                                                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                                                    continue;
                                                                                }




                                                                                break;

                                                                            }
                                                                            else
                                                                            {

                                                                                Console.WriteLine(data01[25]);
                                                                                Console.WriteLine(load_User_Selection_View01_string());
                                                                                data01[1] = Console.ReadLine() ?? string.Empty;
                                                                                continue;

                                                                            }

                                                                        }
                                                                        else
                                                                        {

                                                                            Console.WriteLine(data01[25]);
                                                                            Console.WriteLine(load_User_Selection_View01_string());
                                                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                                                            continue;

                                                                        }


                                                                    }
                                                                    else
                                                                    {

                                                                        Console.WriteLine(data01[25]);
                                                                        Console.WriteLine(load_User_Selection_View01_string());
                                                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                                                        continue;
                                                                    }


                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine(data01[25]);
                                                                    Console.WriteLine(load_User_Selection_View01_string());
                                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                                    continue;
                                                                }




                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine(data01[25]);
                                                                Console.WriteLine(load_User_Selection_View01_string());
                                                                data01[1] = Console.ReadLine() ?? string.Empty;
                                                                continue;

                                                            }


                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine(data01[25]);
                                                            Console.WriteLine(load_User_Selection_View01_string());
                                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                                            continue;
                                                        }





                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(data01[25]);
                                                        Console.WriteLine(load_User_Selection_View01_string());
                                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                                        continue;
                                                    }


                                                }
                                                else
                                                {

                                                    Console.WriteLine("username already taken");
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
                                    }
                                }
                                break;

                            case 39:
                                new User_Main_View01();
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