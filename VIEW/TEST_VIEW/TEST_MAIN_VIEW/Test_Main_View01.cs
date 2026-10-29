using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW
{
    internal class Test_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string =
                                            $"Read all documents\n" +
                                            $"read all text files\n" +
                                            $"movies files\n" +
                                            $"sqlexpress search\n" +
                                            $"read saved text files \n" +
                                            $"Mysql search\n" +
                                            $"sqlite search\n" +
                                            $"linux commands\n" +
                                            $"gguf_01\n" +
                                            $"read pdf\n" +
                                            $"Audio\n" +
                                            "back\n";

        private static string[] menu_array = menu_string.Split("\n");

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Test_Main_View01()
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
                case "Read all documents":
                    _commands.Add(procedure, Read_all_documents);
                    break;
                case "read all text files":
                    _commands.Add(procedure, read_all_text_files);
                    break;
                case "movies files":
                    _commands.Add(procedure, movies_files);
                    break;
                case "sqlexpress search":
                    _commands.Add(procedure, sqlexpress_search);
                    break;
                case "read saved text files":
                    _commands.Add(procedure, read_saved_text_files);
                    break;
                case "Mysql search":
                    _commands.Add(procedure, Mysql_search);
                    break;
                case "sqlite search":
                    _commands.Add(procedure, sqlite_search);
                    break;
                case "linux commands":
                    _commands.Add(procedure, linux_commands);
                    break;
                case "gguf_01":
                    _commands.Add(procedure, gguf_01);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;
                case "read pdf":
                    _commands.Add(procedure, read_pdf);
                    break;
                case "Audio":
                    _commands.Add(procedure, Audio);
                    break;
            }
        }



        private void Read_all_documents()
        {
            new Test_Selection01();
        }
        private void read_all_text_files()
        {
            new Test_Selection02();
        }
        private void movies_files()
        {
            new Test_Selection03();
        }
        private void sqlexpress_search()
        {
            new Test_Selection04();
        }
        private void read_saved_text_files()
        {
            new Test_Selection05();
        }
        private void Mysql_search()
        {
            new Test_Selection06();
        }
        private void sqlite_search()
        {
            new Test_Selection07();
        }
        private void linux_commands()
        {
            new Test_Selection08();
        }
        private void gguf_01()
        {
            new Test_Selection09();
        }
        private void read_pdf()
        {
            new Test_Selection10();
        }
        private void Audio()
        {
            new Test_Selection11();
        }
        private void back()
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
