using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;


namespace EASYPROJECT01.EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_MAIN_VIEW
{
    internal class Sports_Main_View
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"NBA01\n" +
                      $"NBA02\n" +
                      $"NFL\n" +
                      $"go back\n";
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static string[] menu_array = menu_string.Split("\n");
        public Sports_Main_View()
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
            switch (menu_array[int.Parse(data01[1])])
            {
                case "NBA01":
                    _commands.Add(procedure, NBA01);
                    break;
                case "NBA02":
                    _commands.Add(procedure, NBA02);
                    break;
                case "NFL":
                    _commands.Add(procedure, NFL);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
            }
        }
        private void NBA01()
        {
   Console.WriteLine("under developent");
        }
        private void NBA02()
        {
   Console.WriteLine("under developent");
        }
        private void NFL()
        {
   Console.WriteLine("under developent");
        }
        private void go_back()
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
