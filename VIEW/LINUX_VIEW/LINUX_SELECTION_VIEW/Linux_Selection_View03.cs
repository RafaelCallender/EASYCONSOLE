using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.LINUX_VIEW.LINUX_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LINUX_VIEW.LINUX_SELECTION_VIEW
{
    internal class Linux_Selection_View03
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Linux_Services03 Linux_S03 = new Linux_Services03();
        private static string menu_string01 = $"pc_clean_up\n"+
                                              $"go back\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Linux_Selection_View03()
        {
            load_Selection01();
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {
                case "pc_clean_up":
                    _commands.Add(procedure, pc_clean_up);
                    break;
                
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;

            }
        }

        private async void pc_clean_up()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Linux_S03.pc_clean_up());
            }
            else
            {
                Console.WriteLine($"{res.output}");
            }

        }

        private void go_back()
        {
            data01[1] = string.Empty;
            new Linux_Main_View01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[20] += $"{i}.){menu_array01[i]}\n";
            }
            return data01[20];
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
