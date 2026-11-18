using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.MYSQL.MYSQL_SERVICES.MYSQL_SCIENCE_SERVICES.MYSQL_CHEMISTRY_SERVICES;
namespace EASYPROJECT01.EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW
{
    internal class Science_Selection_View04
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static MySql_Chemistry_Services01 MySql_Chemistry_Serv01 = new MySql_Chemistry_Services01();
        private static bool stored_procedure_bool = MySql_Chemistry_Serv01.view_chemistry_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Science_Selection_View04()
        {
            load_Selection01();
        }

        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < stored_procedure_array.Length; i++)
            {
                data01[20] += $"{i}.){stored_procedure_array[i]}\n";
            }
            return data01[20];
        }

        private void load_Selection_data01()
        {
            string procedure = stored_procedure_array[int.Parse(data01[1])];
            switch (procedure)
            {
                case "find_Alkali_Metals":
                    _commands.Add(procedure, find_Alkali_Metals);
                    break;
                case "Find_Actinides":
                    _commands.Add(procedure, Find_Actinides);
                    break;
                case "find_Alkaline_Earth_Metals":
                    _commands.Add(procedure, find_Alkaline_Earth_Metals);
                    break;
                case "find_Lanthanides_Rare_Earth_Metals":
                    _commands.Add(procedure, find_Lanthanides_Rare_Earth_Metals);
                    break;
                case "find_Noble_Gases":
                    _commands.Add(procedure, find_Noble_Gases);
                    break;
                case "find_Nonmetal_Gases_at_Room_Temperature":
                    _commands.Add(procedure, find_Nonmetal_Gases_at_Room_Temperature);
                    break;
                case "find_Transition_Metals":
                    _commands.Add(procedure, find_Transition_Metals);
                    break;
                case "find_element_using_atomic_number":
                    _commands.Add(procedure, find_element_using_atomic_number);
                    break;
                case "find_element_using_symbol":
                    _commands.Add(procedure, find_element_using_symbol);
                    break;
                case "find_element_using_name":
                    _commands.Add(procedure, find_element_using_name);
                    break;
                case "view_all_elements":
                    _commands.Add(procedure, view_all_elements);
                    break;
            }


        }

        private async void find_Alkali_Metals()
        {

            Console.WriteLine(await MySql_Chemistry_Serv01.find_Alkali_Metals());
        }
        private async void Find_Actinides()
        {
            Console.WriteLine(await MySql_Chemistry_Serv01.Find_Actinides());
        }
        private async void find_Alkaline_Earth_Metals()
        {

            Console.WriteLine(await MySql_Chemistry_Serv01.find_Alkaline_Earth_Metals());


        }
        private async void find_Lanthanides_Rare_Earth_Metals()
        {
            Console.WriteLine(await MySql_Chemistry_Serv01.find_Lanthanides_Rare_Earth_Metals());
        }
        private async void find_Noble_Gases()
        {
            Console.WriteLine(await MySql_Chemistry_Serv01.find_Noble_Gases());
        }
        private async void find_Nonmetal_Gases_at_Room_Temperature()
        {
            Console.WriteLine(await MySql_Chemistry_Serv01.find_Nonmetal_Gases_at_Room_Temperature());
        }
        private async void find_Transition_Metals()
        {
            Console.WriteLine(await MySql_Chemistry_Serv01.find_Transition_Metals());


        }

        private void find_element_using_atomic_number()
        {
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                var res = MySql_Chemistry_Serv01.find_element_using_atomic_number(data01[2], out data01[24]);
                if (res == true)
                {
                    Console.WriteLine(data01[24]);
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
        private void find_element_using_symbol()
        {
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                var res = MySql_Chemistry_Serv01.find_element_using_symbol(data01[2], out data01[24]);
                if (res == true)
                {
                    Console.WriteLine(data01[24]);
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
        private void find_element_using_name()
        {
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                var res = MySql_Chemistry_Serv01.find_element_using_name(data01[2], out data01[24]);
                if (res == true)
                {
                    Console.WriteLine(data01[24]);
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
        private void view_all_elements()
        {
            Console.WriteLine(MySql_Chemistry_Serv01.view_all_elements());
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
                    int stringlength = stored_procedure_array.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = stored_procedure_array[selection].Trim();
                        load_Selection_data01();
                        if (stored_procedure_bool == true)
                        {
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
                            Console.WriteLine($"error:{stored_procedure_string}");
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
