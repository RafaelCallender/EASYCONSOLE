using System;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW;


namespace EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW
{
    internal class Life_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"The Bible\n" +
                $"The Book of Enoch.\n" +
                $"The Book of Jubilees\n" +
                $"all Books\n" +
                $"Book_of_Jasher\n" +
                $"book_of_judith\n" +
                $"Dead_Sea_Scrolls\n" +
                $"The_Book_of_TOB\n" +
                $"go back\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Life_Main_View01()
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

                case "The Bible":
                    _commands.Add(procedure, The_Bible);
                    break;
                case "The Book of Enoch":
                    _commands.Add(procedure, The_Book_of_Enoch);
                    break;
                case "The Book of Jubilees":
                    _commands.Add(procedure, The_Book_of_Jubilees);
                    break;
                case "all Books":
                    _commands.Add(procedure, all_Books);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
                case "Book_of_Jasher":
                    _commands.Add(procedure, Book_of_Jasher);
                    break;
                case "book_of_judith":
                    _commands.Add(procedure, book_of_judith);
                    break;
                case "Dead_Sea_Scrolls":
                    _commands.Add(procedure, Dead_Sea_Scrolls);
                    break;
                case "The_Book_of_TOB":
                    _commands.Add(procedure, The_Book_of_TOB);
                    break;
            }
        }

        private void The_Bible()
        {
            new Life_Selection_View01();
        }
        private void The_Book_of_Enoch()
        {
            new Life_Selection_View02();
        }
        private void The_Book_of_Jubilees()
        {
            new Life_Selection_View03();
        }
        private void all_Books()
        {
            new Life_Selection_View04();
        }
        private void go_back()
        {
            Program.load_main();
        }
        private void Book_of_Jasher()
        {
            new Life_Selection_View05();
        }
        private void book_of_judith()
        {
            new Life_Selection_View06();
        }
        private void Dead_Sea_Scrolls()
        {
            new Life_Selection_View07();
        }
        private void The_Book_of_TOB()
        {
            new Life_Selection_View08();
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
