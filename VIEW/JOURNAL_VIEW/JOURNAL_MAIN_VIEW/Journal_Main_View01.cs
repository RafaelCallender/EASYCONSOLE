using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_SELECTION_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_MAIN_VIEW
{
    internal class Journal_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"Journal sqlexpress\n" +
                  $"Journal sqlite\n" +
                  $"Journal Mysql\n" +
                  $"go back";

        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Journal_Main_View01()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1])].Trim();
            switch (menu_array[int.Parse(data01[1])])
            {


                case "Journal sqlexpress":
                    _commands.Add(procedure, Journal_sqlexpress);
                    break;
                case "Journal sqlite":
                    _commands.Add(procedure, Journal_sqlite);
                    break;
                case "Journal Mysql":
                    _commands.Add(procedure, Journal_Mysql);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;

            }
        }
        private void Journal_sqlexpress()
        {
            new Journal_Selection_View01();
        }
        private void Journal_sqlite()
        {
            new Journal_Selection_View02();
        }
        private void Journal_Mysql()
        {
            new Journal_Selection_View03();
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
