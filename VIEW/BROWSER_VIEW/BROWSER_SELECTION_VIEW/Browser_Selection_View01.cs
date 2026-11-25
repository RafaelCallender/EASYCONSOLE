using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.BROWSER.BROWSER_SERVICE;
using EASYPROJECT01.EASYCONSOLE.VIEW.BROWSER_VIEW.BROWSER_MAIN_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.BROWSER_VIEW.BROWSER_SELECTION_VIEW
{
    internal class Browser_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Browser_Service Browser_S01 = new Browser_Service();
        private static string menu_string = $"turboscribe\n" +
                                            $"back\n";

        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Browser_Selection_View01()
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
                case "turboscribe":
                    _commands[procedure] = turboscribe;
                    break;
                case "back":
                    _commands[procedure] = go_back;
                    break;

            }

        }
        private async void turboscribe()
        {

            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                if (Browser_S01.google_search_selenium01(out data01[02]) == true)
                {

                    Console.WriteLine($"{data01[02]}");
                }
                else
                {
                    Console.WriteLine($"{data01[02]}");
                }
            }
            else
            {
                Console.WriteLine($"{res.output}");
            }
        }
        private void go_back()
        {
            new Browser_Main_View01();
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
