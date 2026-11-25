using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.INDEX_VIEW.INDEX_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.SELECTION_VIEW.SELECTION_MAIN_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.INDEX_VIEW.INDEX_SELECTION_VIEW
{
    internal class Index_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Client_Services01 Sql_Client_Ser01 = new Sql_Client_Services01();
        private static string menu_string = $"client login\n";
        private static string[] menu_array = menu_string.Split("\n", StringSplitOptions.RemoveEmptyEntries);
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Index_Selection_View01()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {
                case "client login":
                    _commands[procedure] = client_login;
                    break;
                case "go back":
                    _commands[procedure] = go_back;
                    break;

            }

        }
        private void client_login()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[24]) == true)
            {
                Console.WriteLine($"password");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[25]) == true)
                {
                    if (Sql_Client_Ser01.find_client_username_password(data01[2], data01[3], out data01[26]) == true)
                    {
                        Console.WriteLine($"{data01[26]}");
                        new Selection_Main_View01();
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
        private void go_back()
        {
            new Index_Main_View01();
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
                    int stringlength = menu_array.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array[selection].Trim();
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
