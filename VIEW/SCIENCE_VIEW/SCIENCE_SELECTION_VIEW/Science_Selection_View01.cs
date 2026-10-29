using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES;



namespace EASYPROJECT01.EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    internal class Science_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Chemistry_Services01 Chemistry_Serv01 = new Chemistry_Services01();
        private static Security_Services01 Security_Serv01 = new Security_Services01();
  private static string menu_string01 = $"find_element_using_textfile\n" +
            $"view_all_elements_using_textfile\n" +
            $"find_element_using_textfile_grid\n" +
            $"find_category_elements_using_textfile\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Science_Selection_View01()
        {
            load_Selection01();
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

        private void load_Selection_data01()
        {
            string procedure = menu_array01[int.Parse(data01[1])];
            switch (procedure)
            {
               case "find_element_using_textfile":
                    _commands.Add(procedure, find_element_using_textfile);
                    break;
                case "view_all_elements_using_textfile":
                    _commands.Add(procedure, view_all_elements_using_textfile);
                    break;
                case "find_category_elements_using_textfile":
                    _commands.Add(procedure, find_category_elements_using_textfile);
                    break;
                case "find_element_using_textfile_grid":
                    _commands.Add(procedure, find_element_using_textfile_grid);
                    break;
            }


        }

        private void find_element_using_textfile()
        {
            Console.WriteLine("find elmeent");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine(Chemistry_Serv01.find_element_using_textfile(data01[2]));

            }
            else
            {
                Console.WriteLine(data01[23]);
            }

        }
        private void view_all_elements_using_textfile()
        {
            Console.WriteLine(Chemistry_Serv01.view_all_elements_using_textfile());

        }
        private void find_category_elements_using_textfile()
        {
            Console.WriteLine("find elmeent");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[24]) == true)
            {
                Console.WriteLine(Chemistry_Serv01.find_category_elements_using_textfile(int.Parse(data01[2])));
            }
            else
            {
                Console.WriteLine(data01[24]);
            }
        }
        private void find_element_using_textfile_grid()
        {
            Console.WriteLine("only on web and mobile");
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
