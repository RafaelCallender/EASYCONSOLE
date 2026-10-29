using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQLITE.SQLITE_SERVICES.SQLITE_JOURNAL_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_SELECTION_VIEW
{
    internal class Journal_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sqlite_Journal_Services01 Sqlite_Journal_Serv01 = new Sqlite_Journal_Services01();
        private static bool stored_procedure_bool = Sqlite_Journal_Serv01.view_journal_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Journal_Selection_View02()
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
                    case "insert_journal":
                        _commands.Add(procedure, insert_journal);
                        break;
                    case "find_message_using_message":
                        _commands.Add(procedure, find_message_using_message);
                        break;
                    case "find_message_using_upload":
                        _commands.Add(procedure, find_message_using_upload);
                        break;
                    case "find_message_using_username":
                        _commands.Add(procedure, find_message_using_username);
                        break;
                    case "find_upload_using_message":
                        _commands.Add(procedure, find_upload_using_message);
                        break;
                    case "find_upload_using_upload":
                        _commands.Add(procedure, find_upload_using_upload);
                        break;
                    case "find_upload_using_username":
                        _commands.Add(procedure, find_upload_using_username);
                        break;
                    case "find_username_using_message":
                        _commands.Add(procedure, find_username_using_message);
                        break;
                    case "find_username_using_upload":
                        _commands.Add(procedure, find_username_using_upload);
                        break;
                    case "find_username_using_username":
                        _commands.Add(procedure, find_username_using_username);
                        break;
                    case "view_journal_database_storedprocedures":
                        _commands.Add(procedure, view_journal_database_storedprocedures);
                        break;
                }
            }
        }
        private string ShowMenu()
        {
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                data01[20] += $"{i}.) {stored_procedure_array[i]}\n";
            }
            return data01[20];
        }
        private void find_message_using_message()
        {
            Console.Write("message");

            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {

                if (Sqlite_Journal_Serv01.find_message_using_message(data01[5], out data01[25]) == true)
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

        private void find_message_using_upload()
        {
            Console.WriteLine("not yet developed");
        }
        private void find_message_using_username()
        {
            Console.WriteLine("not yet developed");
        }
        private void find_upload_using_message()
        {
            Console.WriteLine("not yet developed");
        }
        private void find_upload_using_upload()
        {
            Console.WriteLine("not yet developed");
        }
        private void find_upload_using_username()
        {
            Console.WriteLine("not yet developed");
        }
        private void find_username_using_message()
        {
            Console.WriteLine("not yet developed");
        }
        private void find_username_using_upload()
        {
            Console.WriteLine("not yet developed");
        }
        private void find_username_using_username()
        {
            Console.WriteLine("not yet developed");
        }
        private void view_journal_database_storedprocedures()
        {
            Console.WriteLine("not yet developed");
        }
        private void insert_journal()
        {
            Console.WriteLine("not yet developed");
        }

        private void load_Selection01()
        {
            Console.WriteLine(ShowMenu());
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
