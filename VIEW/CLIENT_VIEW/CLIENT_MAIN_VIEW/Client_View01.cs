using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_SELECTION_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW
{
    internal class Client_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        private static string menu_string01 = $"client sqlexpress\n" +
                                       $"client sqlite\n" +
                                       $"client Mysql\n" +
                                       $"go back\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
          private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Client_View01()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[20] += $"{i}.) {menu_array01[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1])].Trim();
            switch (procedure)
            {

                case "client sqlexperss":
                    _commands.Add(procedure, client_sqlexperss);
                    break;
                case "client sqlite":
                    _commands.Add(procedure, client_sqlite);
                    break;
                case "client Mysql":
                    _commands.Add(procedure, client_Mysql);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;
            }
        }
        private void client_sqlexperss()
        {
            new Client_Selection_View01();
        }
        private void client_sqlite()
        {
            new Client_Selection_View02();
        }
        private void client_Mysql()
        {
            new Client_Selection_View03();
        }
        private void back()
        {
            Program.load_main();
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
                    int stringlength = menu_array01.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array01[selection].Trim();
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
