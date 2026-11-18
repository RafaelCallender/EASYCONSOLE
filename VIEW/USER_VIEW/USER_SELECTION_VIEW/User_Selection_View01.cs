using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.USER_VIEW.USER_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_USER_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_MANAGER.SQL_USER_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.USER_MODEL;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.USER_VIEW.USER_SELECTION_VIEW
{
    internal class User_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Services01 Sql_Serv01 = new Sql_Services01();
        private static Location_Helper01 Location_H01 = new Location_Helper01();
        private static File_Picker01 File_P01 = new File_Picker01();
        private static User_Model01 User_M01 = new User_Model01();
        private static bool stored_proccedure_bool = Sql_Serv01.view_user_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public User_Selection_View01()
        {

            if (stored_proccedure_bool == true)
            {
                load_Selection01();
            }
            else
            {
                Console.WriteLine(stored_procedure_string);
            }

        }
        private void load_Selection_data01()
        {

            string procedure = stored_procedure_array[int.Parse(data01[1])].Trim();
            switch (procedure)
            {
                case "delete_user_using_phonenumber":
                    _commands.Add(procedure, delete_user_using_phonenumber);
                    break;
                case "delete_user_using_username":
                    _commands.Add(procedure, delete_user_using_username);
                    break;
                case "find_email_using_email":
                    _commands.Add(procedure, find_email_using_email);
                    break;
                case "find_email_using_username":
                    _commands.Add(procedure, find_email_using_username);
                    break;
                case "find_password_using_email":
                    _commands.Add(procedure, find_password_using_email);
                    break;
                case "find_password_using_username":
                    _commands.Add(procedure, find_password_using_username);
                    break;
                case "find_phonenumber_using_email":
                    _commands.Add(procedure, find_phonenumber_using_email);
                    break;
                case "find_phonenumber_using_phonenumber":
                    _commands.Add(procedure, find_phonenumber_using_phonenumber);
                    break;
                case "find_phonenumber_using_username":
                    _commands.Add(procedure, find_phonenumber_using_username);
                    break;
                case "find_user_location_using_email":
                    _commands.Add(procedure, find_user_location_using_email);
                    break;
                case "find_user_location_using_username":
                    _commands.Add(procedure, find_user_location_using_username);
                    break;
                case "find_username_password":
                    _commands.Add(procedure, find_username_password);
                    break;
                case "find_username_using_email":
                    _commands.Add(procedure, find_username_using_email);
                    break;
                case "find_username_using_username":
                    _commands.Add(procedure, find_username_using_username);
                    break;

                case "insert_text_file_using_username":
                    _commands.Add(procedure, insert_text_file_using_username);
                    break;
                case "insert_user":
                    _commands.Add(procedure, insert_user);
                    break;
                case "insert_user_audio_file_using_username":
                    _commands.Add(procedure, insert_user_audio_file_using_username);
                    break;
                case "insert_user_text_file_using_username":
                    _commands.Add(procedure, insert_user_text_file_using_username);
                    break;
                case "update_email_using_email":
                    _commands.Add(procedure, update_email_using_email);
                    break;
                case "update_email_using_username":
                    _commands.Add(procedure, update_email_using_username);
                    break;
                case "update_password_using_email":
                    _commands.Add(procedure, update_password_using_email);
                    break;
                case "update_password_using_phonenumber":
                    _commands.Add(procedure, update_password_using_phonenumber);
                    break;
                case "update_password_using_username":
                    _commands.Add(procedure, update_password_using_username);
                    break;
                case "update_phonenumber_using_email":
                    _commands.Add(procedure, update_phonenumber_using_email);
                    break;
                case "update_phonenumber_using_username":
                    _commands.Add(procedure, update_phonenumber_using_username);
                    break;

                case "update_user_location_using_name":
                    _commands.Add(procedure, update_user_location_using_name);
                    break;
                case "update_user_location_using_phonenumber":
                    _commands.Add(procedure, update_user_location_using_phonenumber);
                    break;
                case "update_user_location_using_username":
                    _commands.Add(procedure, update_user_location_using_username);
                    break;
                case "update_username_using_email":
                    _commands.Add(procedure, update_username_using_email);
                    break;
                case "update_username_using_phonenumber":
                    _commands.Add(procedure, update_username_using_phonenumber);
                    break;
                case "update_username_using_username":
                    _commands.Add(procedure, update_username_using_username);
                    break;
                case "user_login":
                    _commands.Add(procedure, user_login);
                    break;
                case "view_all_emails":
                    _commands.Add(procedure, view_all_emails);
                    break;
                case "view_all_passwords":
                    _commands.Add(procedure, view_all_passwords);
                    break;
                case "view_all_phonenumber":
                    _commands.Add(procedure, view_all_phonenumber);
                    break;
                case "view_all_username":
                    _commands.Add(procedure, view_all_username);
                    break;
                case "view_user_table":
                    _commands.Add(procedure, view_user_table);
                    break;

            }
        }
        private void delete_user_using_phonenumber()
        {

            Console.WriteLine($"phonenumber");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.delete_user_using_phonenumber(data01[2], out data01[25]) == true)
                {

                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[25]}");
            }

        }
        private void delete_user_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.delete_user_using_username(data01[2], out data01[25]) == true)
                {
                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[25]}");
            }

        }
        private void find_email_using_email()
        {
            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Security_Serv01.email_check(data01[2], out data01[24]) == true)
                {

                    if (Sql_Serv01.find_email_using_email(data01[2], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");

                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_email_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.find_email_using_username(data01[2], out data01[25]) == true)
                {
                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_password_using_email()
        {
            Console.WriteLine($"phonenumber");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[2], out data01[24]) == true)
                {
                    if (Sql_Serv01.find_password_using_email(data01[2], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_password_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.find_password_using_username(data01[2], out data01[25]) == true)
                {
                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_phonenumber_using_email()
        {
            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[2], out data01[24]) == true)
                {

                    if (Sql_Serv01.find_phonenumber_using_email(data01[2], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_phonenumber_using_phonenumber()
        {
            Console.WriteLine($"phonenumber");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[2], out data01[24]) == true)
                {

                    if (Sql_Serv01.find_user_location_using_username(data01[2], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_phonenumber_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.find_phonenumber_using_username(data01[2], out data01[25]) == true)
                {
                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_user_location_using_email()
        {
            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[2], out data01[24]) == true)
                {

                    if (Sql_Serv01.find_user_location_using_username(data01[2], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_user_location_using_username()
        {

            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.find_user_location_using_username(data01[2], out data01[25]) == true)
                {
                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_username_password()
        {
            Console.WriteLine($"password");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.find_username_password(data01[2], out data01[25]) == true)
                {
                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_username_using_email()
        {
            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.empty_string(data01[2], out data01[24]) == true)
                {

                    if (Sql_Serv01.find_username_using_email(data01[2], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void find_username_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                if (Sql_Serv01.find_username_using_username(data01[2], out data01[25]) == true)
                {
                    Console.WriteLine($"{data01[25]}");
                }
                else
                {
                    Console.WriteLine($"{data01[25]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void insert_text_file_using_username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void insert_user()
        {
            if (Sql_Serv01.insert_user(data01[2], data01[2], data01[2], data01[2], data01[2], data01[2], data01[2], out data01[1]) == true)
            {
                Console.WriteLine($"not yet developed");

            }
            else
            {
                Console.WriteLine($"not yet developed");
            }

        }
        private void insert_user_audio_file_using_username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void insert_user_text_file_using_username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void update_email_using_email()
        {
            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[2], out data01[24]) == true)
                {
                    Console.WriteLine($"new email");
                    data01[3] = Console.ReadLine();
                    if (Security_Serv01.empty_string(data01[3], out data01[25]) == true)
                    {
                        if (Security_Serv01.email_check(data01[3], out data01[26]) == true)
                        {
                            if (Sql_Serv01.update_email_using_email(data01[2], data01[3], out data01[27]) == true)
                            {
                                Console.WriteLine($"{data01[27]}");
                            }
                            else
                            {
                                Console.WriteLine($"{data01[27]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }


        private void update_username_using_email()
        {

            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[3], out data01[24]) == true)
                {
                    Console.WriteLine($"new usernme");
                    data01[3] = Console.ReadLine();

                    if (Sql_Serv01.update_username_using_email(data01[2], data01[3], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }
        }
        private void update_email_using_username()
        {

            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine($"new email");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                {
                    if (Security_Serv01.email_check(data01[3], out data01[25]) == true)
                    {
                        if (Sql_Serv01.update_email_using_username(data01[2], data01[3], out data01[26]) == true)
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                        else
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void update_password_using_email()
        {
            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[3], out data01[24]) == true)
                {
                    Console.WriteLine($"new password");
                    data01[3] = Console.ReadLine();
                    if (Security_Serv01.empty_string(data01[3], out data01[25]) == true)
                    {

                        if (Sql_Serv01.update_email_using_username(data01[2], data01[3], out data01[26]) == true)
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                        else
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void update_password_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine($"new password");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                {

                    if (Sql_Serv01.update_password_using_username(data01[2], data01[3], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }

                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void update_phonenumber_using_email()
        {
            Console.WriteLine($"email");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[2], out data01[24]) == true)
                {
                    Console.WriteLine($"new phonenumber");
                    data01[3] = Console.ReadLine();
                    if (Security_Serv01.empty_string(data01[3], out data01[25]) == true)
                    {
                        if (Security_Serv01.phone_check(data01[3], out data01[26]) == true)
                        {
                            if (Sql_Serv01.update_phonenumber_using_email(data01[2], data01[3], out data01[27]) == true)
                            {
                                Console.WriteLine($"{data01[27]}");
                            }
                            else
                            {
                                Console.WriteLine($"{data01[27]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void update_phonenumber_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine($"new phone");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                {
                    if (Security_Serv01.phone_check(data01[3], out data01[25]) == true)
                    {
                        if (Sql_Serv01.update_phonenumber_using_username(data01[2], data01[3], out data01[26]) == true)
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                        else
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void update_user_location_using_phonenumber()
        {
            Console.WriteLine($"not yet developed");
        }
        private void update_user_location_using_username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void update_username_using_phonenumber()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine($"new phone");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                {
                    if (Security_Serv01.phone_check(data01[3], out data01[25]) == true)
                    {
                        if (Sql_Serv01.update_username_using_phonenumber(data01[2], data01[3], out data01[26]) == true)
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                        else
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void update_password_using_phonenumber()
        {
            Console.WriteLine($"phonenumber");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[3], out data01[24]) == true)
                {
                    Console.WriteLine($"new password");
                    data01[3] = Console.ReadLine();
                    if (Security_Serv01.empty_string(data01[3], out data01[25]) == true)
                    {

                        if (Sql_Serv01.update_password_using_phonenumber(data01[2], data01[3], out data01[26]) == true)
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                        else
                        {
                            Console.WriteLine($"{data01[26]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void update_username_using_username()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine($"new username");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                {

                    if (Sql_Serv01.update_username_using_username(data01[2], data01[3], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }

                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }

        }
        private void user_login()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine($"password");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                {

                    if (Sql_Serv01.user_login(data01[2], data01[3], out data01[25]) == true)
                    {
                        Console.WriteLine($"{data01[25]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data01[25]}");
                    }

                }
                else
                {
                    Console.WriteLine($"{data01[24]}");
                }
            }
            else
            {
                Console.WriteLine($"{data01[23]}");
            }
        }
        private void view_all_emails()
        {
            // Console.WriteLine($"{Sql_Serv01.view_all_emails();
            Console.WriteLine($"not devekoped yet");
        }
        private void view_all_passwords()
        {
            Console.WriteLine($"{Sql_Serv01.view_all_passwords}");
        }
        private void view_all_phonenumber()
        {
            Console.WriteLine($"{Sql_Serv01.view_all_phonenumber}");
        }
        private void view_all_username()
        {
            Console.WriteLine($"{Sql_Serv01.view_all_username}");
        }
        private void view_user_table()
        {
            Console.WriteLine($"not yet developed");
        }
        private void update_user_location_using_email()
        {

            Console.WriteLine($"not devekoped yet");
        }
        private void update_user_location_using_name()
        {
            Console.WriteLine($"not developed yet");
        }
        private void load_Selection01()
        {
            Console.WriteLine($"{stored_procedure_string}");
            data01[1] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                {
                    int selection = int.Parse(data01[1].Trim());
                    int stringlength = stored_procedure_array.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = stored_procedure_array[selection].Trim();
                        load_Selection_data01();
                        if (_commands.TryGetValue(key, out Action action))
                        {
                            action();
                            _commands.Clear();

                        }
                        else
                        {
                            Console.WriteLine($"{key} command not found");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);

                }
            }
        }
    }
}
