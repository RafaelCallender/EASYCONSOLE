using EASYPROJECT01.EASY_CALLENDER01.SERVICES.NETWORK_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.NETWROK_VIEW.NETWORK_MAIN_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.NETWROK_VIEW.NETWORK_SELECTION_VIEW
{
    internal class Network_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Network_Services01 Network_S01 = new Network_Services01();
        private static string menu_string01 = $"scan network\n" +
                         $"network monitor\n" +
                         $"network_monitor01\n" +
                         $"go back\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Network_Selection_View01()
        {
            load_Network_Selection_View01();
        }

        private void load_movies_Services01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[int.Parse(data01[4])])
                {
             
                    case "scan network":
                        _commands.Add(procedure, scan_network);
                        break;
                    case "network monitor":
                        _commands.Add(procedure, network_monitor);
                        break;
                    case "network monitor01":
                        _commands.Add(procedure, network_monitor01);
                        break;
                    case "go_back":
                        _commands.Add(procedure, go_back);
                        break;
                }
            }
    
        }

        private void scan_network()
        {
            Console.WriteLine(Network_S01.scan_netwrok());
        }

        private void network_monitor()
        {
            Console.WriteLine(Network_S01.network_monitor());
        }

        private void network_monitor01()
        {
            Console.WriteLine(Network_S01.network_monitor01());
        }
        private void go_back()
        {
            new Network_Main_View01();
        }

        private void load_Network_Selection_View01()
        {

            int stringlength = menu_array01.Length;
            for (int i = 0; i < stringlength; i++)
            {
                Console.WriteLine($"{i}.){menu_array01[i]}");

            }
            data01[4] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[4], out data01[23]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[4], out data01[24]) == true)
                {
                    int selection = int.Parse(data01[4].Trim());
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array01[selection].Trim();
                        load_movies_Services01();

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
            else
            {
                Console.WriteLine(data01[23]);
            }
        }
    }
}