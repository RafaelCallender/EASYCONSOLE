using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_LANGUAGE_SERVICES;


namespace EASYPROJECT01.EASYCONSOLE.VIEW.LANGUAGE_VIEW.LANGUAGE_SELECTION_VIEW
{
    internal class Language_Selection_View03
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static MySql_Language_Services01 MySql_Language_S01 = new MySql_Language_Services01();
        private static bool stored_procedure_bool = MySql_Language_S01.view_languge_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Language_Selection_View03()
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
        private void load_Selection_data01()
        {
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                string procedure = stored_procedure_array[i].Trim();
                switch (stored_procedure_array[int.Parse(data01[4])])
                {

                    case "find_code_using_code":
                        _commands.Add(procedure, find_code_using_code);
                        break;
                    case "find_code_using_language":
                        _commands.Add(procedure, find_code_using_language);
                        break;
                    case "find_language_using_code":
                        _commands.Add(procedure, find_language_using_code);
                        break;
                    case "find_language_using_Language":
                        _commands.Add(procedure, find_language_using_Language);
                        break;
                    case "insert_language":
                        _commands.Add(procedure, insert_language);
                        break;
                    case "view_all_data_from_language_table":
                        _commands.Add(procedure, view_all_data_from_language_table);
                        break;
                    case "view_languge_database_storedprocedures":
                        _commands.Add(procedure, view_languge_database_storedprocedures);
                        break;
                }
            }
        }
        private void insert_language()
        {
            Console.WriteLine($"language name\n");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {

                Console.WriteLine($"language code\n");
                data01[3] = Console.ReadLine() ?? string.Empty;
                if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                {

                    if (MySql_Language_S01.insert_language(data01[3], data01[4], out data01[25]) == true)
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

        private void find_code_using_code()
        {
            Console.Write("language code");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {

                if (MySql_Language_S01.find_code_using_code(data01[5], out data01[24]) == true)
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
        private void find_code_using_language()
        {
            Console.Write("language name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {

                if (MySql_Language_S01.find_code_using_language(data01[5], out data01[24]) == true)
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
        private void find_language_using_code()
        {
            Console.Write("language code");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {

                if (MySql_Language_S01.find_language_using_code(data01[5], out data01[24]) == true)
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
        private void find_language_using_Language()
        {
            Console.Write("language name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {

                if (MySql_Language_S01.find_language_using_Language(data01[5], out data01[24]) == true)
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


        private void view_all_data_from_language_table()
        {

            if (MySql_Language_S01.view_all_data_from_language_table(out data01[24]) == true)
            {
                Console.WriteLine(data01[25]);
            }
            else
            {
                Console.WriteLine(data01[25]);
            }
        }
        private void view_languge_database_storedprocedures()
        {
            if (MySql_Language_S01.view_all_data_from_language_table(out data01[24]) == true)
            {
                Console.WriteLine(data01[25]);
            }
            else
            {
                Console.WriteLine(data01[25]);
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
