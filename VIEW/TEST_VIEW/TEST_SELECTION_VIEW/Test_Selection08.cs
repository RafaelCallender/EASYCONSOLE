using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection08
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Linux_Helper01 Linux_H01 = new Linux_Helper01();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();
        private static string menu_string = $"linux string 01\n" +
           $"linux Directory search\n" +
           $"linux file search\n" +
           $"back\n";
        private static string[] menu_array = menu_string.Split("\n");

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Test_Selection08()
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
                case "linux string 01":
                    _commands.Add(procedure, linux_string_01);
                    break;
                case "linux Directory search":
                    _commands.Add(procedure, linux_Directory_search);
                    break;
                case "linux file search":
                    _commands.Add(procedure, linux_file_search);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;
            }
        }
        private void linux_string_01()
        {
            Console.WriteLine(Linux_Helper01.linux_OneDrive_array[(int)Linux_Helper01.linux_OneDrive01_index.DeleteRemoteFolder]);
          
        }
        private void linux_Directory_search()
        {
            Console.WriteLine($"directory name\n");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                Console.WriteLine(File_S01.find_directory(data01[3]));
        
            }
            else
            {
                Console.WriteLine(data01[23]);
               
            }
        }
        private void linux_file_search()
        {
            Console.WriteLine($"file name\n");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                Console.WriteLine(File_S01.find_files(data01[3].Trim()));
         
            }
            else
            {
                Console.WriteLine(data01[23]);
         
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
