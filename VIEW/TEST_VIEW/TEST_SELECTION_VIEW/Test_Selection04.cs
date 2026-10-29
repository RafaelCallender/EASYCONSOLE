using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_HELPER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection04
    {


        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Helper01 Sql_H01 = new Sql_Helper01();
        //  private static Language_Services01 Language_Serv01 = new Language_Services01();
        private static string menu_string =
                     $"built sql server \n" +
                     $"sql sections \n" +
                     $"built sql server 01 \n" +
                     $"Back \n";


        private static string[] menu_array = menu_string.Split("\n");

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Test_Selection04()
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
                case "built sql server":
                    _commands.Add(procedure, built_sql_server);
                    break;
                case "sql sections":
                    _commands.Add(procedure, sql_sections);
                    break;
                case "built sql server 01":
                    _commands.Add(procedure, built_sql_server_01);
                    break;
                case "back":
                    _commands.Add(procedure, Back);
                    break;
            }
        }
        private void built_sql_server()
        {
            data01[2] = Sql_H01.build_connection_string01(
                  (int)Sql_Helper01.connectionStringdatabase.Chemistry_Database,
                  (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
                  true);


            Console.WriteLine(data01[2]);
     
        }
        private void sql_sections()
        {
            int number = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;
            data01[2] = number.ToString();
            Console.WriteLine(data01[2]);
  
        }
        private void built_sql_server_01()
        {

            data01[2] = Sql_H01.build_connection_string02(
(int)Sql_Helper01.connectionStringServer.SqlExpress_server,
(int)Sql_Helper01.connectionStringdatabase.Chemistry_Database,
true);

            Console.WriteLine(data01[2]);
  
        }
        private void Back()
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
                        Console.WriteLine(data01[24]);
              

                    }

                }
                else
                {
                    Console.WriteLine(data01[23]);
            

                }

            }

        }

    }
}
