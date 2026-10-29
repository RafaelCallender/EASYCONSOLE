using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.UPLOAD_VIEW.UPLOAD_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_UPLOAD_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.UPLOAD_VIEW.UPLOAD_SELECTION_VIEW
{
    internal class Upload_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Upload_Services01 Sql_Upload_S01 = new Sql_Upload_Services01();
        private static bool stored_proccedure_bool = Sql_Upload_S01.view_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Upload_Selection_View01()
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
        private string load_Upload_Selection_View01_string()
        {

            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                data01[80] += $"{i}.){stored_procedure_array[i]}\n";

            }
            return data01[80];
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                string procedure = stored_procedure_array[i].Trim();
                switch (stored_procedure_array[int.Parse(data01[1])])
                {
                    case "delete_FilePath_using_FilePath":
                        _commands.Add(procedure, delete_FilePath_using_FilePath);
                        break;
                    case "delete_OriginalName_using_OriginalName":
                        _commands.Add(procedure, delete_OriginalName_using_OriginalName);
                        break;
                    case "delete_StoredName_using_StoredName":
                        _commands.Add(procedure, delete_StoredName_using_StoredName);
                        break;
                    case "delete_Username_using_Username":
                        _commands.Add(procedure, delete_Username_using_Username);
                        break;
                    case "find_OriginalName_using_FilePath":
                        _commands.Add(procedure, find_OriginalName_using_FilePath);
                        break;
                    case "find_OriginalName_using_OriginalName":
                        _commands.Add(procedure, find_OriginalName_using_OriginalName);
                        break;
                    case "find_OriginalName_using_StoredName":
                        _commands.Add(procedure, find_OriginalName_using_StoredName);
                        break;
                    case "find_OriginalName_using_Username":
                        _commands.Add(procedure, find_OriginalName_using_Username);
                        break;
                    case "find_StoredName_using_StoredName":
                        _commands.Add(procedure, find_StoredName_using_StoredName);
                        break;
                    case "find_StoredName_using_Username":
                        _commands.Add(procedure, find_StoredName_using_Username);
                        break;
                    case "find_username_using_FilePath":
                        _commands.Add(procedure, find_username_using_FilePath);
                        break;
                    case "find_username_using_OriginalName":
                        _commands.Add(procedure, find_username_using_OriginalName);
                        break;
                    case "find_username_using_StoredName":
                        _commands.Add(procedure, find_username_using_StoredName);
                        break;
                    case "find_username_using_username":
                        _commands.Add(procedure, find_username_using_username);
                        break;
                    case "insert_data":
                        _commands.Add(procedure, insert_data);
                        break;
                    case "update_OriginalName_using_OriginalName":
                        _commands.Add(procedure, update_OriginalName_using_OriginalName);
                        break;
                    case "update_StoredName_using_StoredName":
                        _commands.Add(procedure, update_StoredName_using_StoredName);
                        break;
                    case "update_username_using_username":
                        _commands.Add(procedure, update_username_using_username);
                        break;

                }
            }
        }


        private void delete_FilePath_using_FilePath()
        {
            Console.WriteLine($"not yet developed");
        }
        private void delete_OriginalName_using_OriginalName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void delete_StoredName_using_StoredName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void delete_Username_using_Username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_OriginalName_using_FilePath()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_OriginalName_using_OriginalName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_OriginalName_using_StoredName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_OriginalName_using_Username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_StoredName_using_StoredName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_StoredName_using_Username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_username_using_FilePath()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_username_using_OriginalName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_username_using_StoredName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void find_username_using_username()
        {
            Console.WriteLine($"not yet developed");
        }
        private void insert_data()
        {
            Console.WriteLine($"not yet developed");
        }
        private void update_OriginalName_using_OriginalName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void update_StoredName_using_StoredName()
        {
            Console.WriteLine($"not yet developed");
        }
        private void update_username_using_username()
        {
            Console.WriteLine($"not yet developed");
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
