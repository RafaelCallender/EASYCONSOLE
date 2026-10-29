using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_HELPER;
using System.ComponentModel;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection06
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static MySql_Helper01 MySql_H01 = new MySql_Helper01();
        private static string menu_string = $"Mysql build_connection_string01\n" +

                $"2.) back\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Test_Selection06()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.) {menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1])].Trim();
            switch (procedure)
            {
                case "Mysql build_connection_string01":
                    _commands.Add(procedure, Mysql_build_connection_string01);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;
            }
        }
        private void Mysql_build_connection_string01()
        {
            Console.WriteLine(MySql_H01.build_connection_string01(
                      (int)MySql_Helper01.connectionStringServer.MySql_server,
                      (int)MySql_Helper01.connectionStringUser.root,
                      (int)MySql_Helper01.connectionStringdatabase.Clients01_Database,
                      true));
   
        }
        private void back()
        {
            new Test_Main_View01();
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
