using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection05
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"mytextfile01\n" +
                        $"mytextfile02\n" +
                        $"mytextfile03\n" +
                        $"mytextfile04\n" +
                        $"mytextfile05\n" +
                        $"mytextfile06\n" +
                        $"mytextfile07\n" +
                        $"mytextfile08\n" +
                        $"mytextfile09\n" +
                        $"list all\n" +
                        $"back\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Test_Selection05()
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
                case "mytextfile01":
                    _commands.Add(procedure, mytextfile01);
                    break;
                case "mytextfile02":
                    _commands.Add(procedure, mytextfile02);
                    break;
                case "mytextfile03":
                    _commands.Add(procedure, mytextfile03);
                    break;
                case "mytextfile04":
                    _commands.Add(procedure, mytextfile04);
                    break;
                case "mytextfile05":
                    _commands.Add(procedure, mytextfile05);
                    break;
                case "mytextfile06":
                    _commands.Add(procedure, mytextfile06);
                    break;
                case "mytextfile07":
                    _commands.Add(procedure, mytextfile07);
                    break;
                case "mytextfile08":
                    _commands.Add(procedure, mytextfile08);
                    break;
                case "mytextfile09":
                    _commands.Add(procedure, mytextfile09);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;
                case "list all":
                    _commands.Add(procedure, list_all);
                    break;
            }
        }

        private void mytextfile01()
        {
            Console.WriteLine(File_Manger01.save_files[0]);
        }
        private void mytextfile02()
        {
            Console.WriteLine(File_Manger01.save_files[1]);
        }
        private void mytextfile03()
        {
            Console.WriteLine(File_Manger01.save_files[2]);
        }
        private void mytextfile04()
        {
            Console.WriteLine(File_Manger01.save_files[3]);
        }
        private void mytextfile05()
        {
            Console.WriteLine(File_Manger01.save_files[4]);
        }
        private void mytextfile06()
        {
            Console.WriteLine(File_Manger01.save_files[5]);
        }
        private void mytextfile07()
        {
            Console.WriteLine(File_Manger01.save_files[6]);
        }
        private void mytextfile08()
        {
            Console.WriteLine(File_Manger01.save_files[7]);
        }
        private void mytextfile09()
        {
            Console.WriteLine(File_Manger01.save_files[8]);
        }
        private void mytextfile10()
        {
            Console.WriteLine(File_Manger01.save_files[9]);
        }
        private void list_all()
        {
            for (int i = 0; i < File_Manger01.save_files.Length; i++)
            {
                Console.WriteLine(File_Manger01.save_files[i]);
            }

        }
        private void back()
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
