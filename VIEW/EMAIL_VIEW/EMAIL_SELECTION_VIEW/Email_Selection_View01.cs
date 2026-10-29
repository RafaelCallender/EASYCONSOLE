using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.EMAIL_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_EMIAL_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW
{
    internal class Email_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Email_Services01 Email_S01 = new Email_Services01();
        private static Sql_Email_Services01 Sql_Email_S01 = new Sql_Email_Services01();
        private static bool stored_procedure_bool = Sql_Email_S01.view_email_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Email_Selection_View01()
        {
            if (stored_procedure_bool == true)
            {
                load_Selection01();
            }
            else
            {
                Console.WriteLine(stored_procedure_string);
            }
        }

        private string ShowMenu()
        {
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                data01[20] += $"{i}.){stored_procedure_array[i]}\n";
            }
            return data01[20];
        }

        private void load_Selection_data01()
        {
            string procedure = stored_procedure_array[int.Parse(data01[4])];
            switch (stored_procedure_array[int.Parse(data01[4])])
            {
                case "find_email_using_email":
                    _commands.Add(procedure, find_email_using_email);
                    break;

                case "find_email_using_name":
                    _commands.Add(procedure, find_email_using_name);
                    break;

                case "find_email_using_phonenumber":
                    _commands.Add(procedure, find_email_using_phonenumber);
                    break;

                case "find_full_name_using_email":
                    _commands.Add(procedure, find_full_name_using_email);
                    break;

                case "find_full_name_using_full_name":
                    _commands.Add(procedure, find_full_name_using_full_name);
                    break;

                case "find_full_name_using_phonenumber":
                    _commands.Add(procedure, find_full_name_using_phonenumber);
                    break;

                case "find_phonenumber_using_email":
                    _commands.Add(procedure, find_phonenumber_using_email);
                    break;

                case "find_phonenumber_using_fullname":
                    _commands.Add(procedure, find_phonenumber_using_fullname);
                    break;

                case "find_phonenumber_using_phonenumber":
                    _commands.Add(procedure, find_phonenumber_using_phonenumber);
                    break;

                case "insert_email":
                    _commands.Add(procedure, insert_email);
                    break;
            }
        }


        private void insert_email()
        {
            Console.WriteLine("full name\n");
            data01[2] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[2], out data01[25]) == true)
            {
                Console.WriteLine("Email Addresss\n");
                data01[3] = Console.ReadLine() ?? string.Empty;
                if (Security_Serv01.empty_string(data01[3], out data01[27]) == true)
                {
                    if (Security_Serv01.email_check(data01[3], out data01[26]) == true)
                    {
                        Console.WriteLine("Phonenumber\n");
                        data01[4] = Console.ReadLine() ?? string.Empty;
                        if (Security_Serv01.empty_string(data01[4], out data01[28]) == true)
                        {
                            if (Security_Serv01.phone_check(data01[4], out data01[29]) == true)
                            {



                                Console.WriteLine("Message\n");
                                data01[5] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[5], out data01[30]) == true)
                                {



                                    if (Email_S01.send_email(data01[2], data01[3], data01[4], data01[5], out data01[31]) == true)
                                    {


                                        if (Sql_Email_S01.insert_email(data01[2], data01[3], data01[4], data01[5], out data01[32]) == true)
                                        {



                                            Console.WriteLine(

                                                $"{data01[31]}\n" +
                                                $"{data01[32]}\n"


                                            );


                                            data01[1] = Console.ReadLine() ?? string.Empty;


                                        }
                                        else
                                        {



                                            Console.WriteLine(data01[32]);
                                            data01[8] = Console.ReadLine() ?? string.Empty;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[31]);
                                        data01[8] = Console.ReadLine() ?? string.Empty;

                                    }
                                }
                                else
                                {
                                    Console.WriteLine(data01[30]);
                                    data01[8] = Console.ReadLine() ?? string.Empty;

                                }
                            }
                            else
                            {
                                Console.WriteLine(data01[28]);
                                data01[6] = Console.ReadLine() ?? string.Empty;

                            }
                        }
                        else
                        {
                            Console.WriteLine(data01[26]);
                            data01[5] = Console.ReadLine() ?? string.Empty;

                        }
                    }
                    else
                    {
                        Console.WriteLine(data01[27]);
                        data01[5] = Console.ReadLine() ?? string.Empty;

                    }
                }
                else
                {
                    Console.WriteLine(data01[25]);
                    data01[3] = Console.ReadLine() ?? string.Empty;

                }
            }


        }

        private void find_email_using_email()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Email_S01.find_email_using_email(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);
                }
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_email_using_name()
        {
            Console.Write("name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Email_S01.find_email_using_name(data01[5], out data01[25]) == true)
                {
                    Console.WriteLine(data01[25]);
                }
                else
                {
                    Console.WriteLine(data01[25]);
                }

            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_email_using_phonenumber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Email_S01.find_email_using_phonenumber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);
                }
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_full_name_using_email()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Email_S01.find_full_name_using_email(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);
                }
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_full_name_using_full_name()
        {
            Console.Write("full name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Email_S01.find_full_name_using_full_name(data01[5], out data01[25]) == true)
                {
                    Console.WriteLine(data01[25]);
                }
                else
                {
                    Console.WriteLine(data01[25]);
                }

            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_full_name_using_phonenumber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Email_S01.find_full_name_using_phonenumber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);
                }
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_phonenumber_using_email()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Email_S01.find_phonenumber_using_email(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);
                }
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_phonenumber_using_fullname()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {


                if (Sql_Email_S01.find_phonenumber_using_fullname(data01[5], out data01[25]) == true)
                {
                    Console.WriteLine(data01[25]);
                }
                else
                {
                    Console.WriteLine(data01[25]);
                }


            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_phonenumber_using_phonenumber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Email_S01.find_phonenumber_using_phonenumber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);
                }
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }



        private void load_Selection01()
        {
            Console.WriteLine($"{ShowMenu()}");
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
