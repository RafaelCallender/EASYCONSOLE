using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.MOVIES_VIEW.MOVIES_MAIN_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.MOVIES_VIEW.MOVIES_SELECTION_VIEW
{
    internal class Movies_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string menu_string01 = $"all movies\n" +
                                              $"go back";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Movies_Selection_View01()
        {
            load_Selection01();
        }
        private void load_Selection_data01()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                string procedure = menu_array01[i].Trim();
                switch (menu_array01[int.Parse(data01[4])])
                {
                    case "all movies":
                        _commands.Add(procedure, all_movies);
                        break;

                    case "go back":
                        _commands.Add(procedure, go_back);
                        break;

                }
            }

        }

        private void all_movies()
        {
            Console.WriteLine($"not yet developed");

        }
        private void go_back()
        {
            new Movies_Main_View01();

        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[20] += $"{i}.){menu_array01[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection01()
        {
            Console.WriteLine($"{ShowMenu}");
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
