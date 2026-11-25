using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection10
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Manger13 File_M13 = new File_Manger13();
        private static File_Manger05 File_M05 = new File_Manger05();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string menu_string01 =
                                         $"Book_of_Jasher\n" +
            $"book_of_judith\n" +
            $"Dead_Sea_Scrolls\n" +
            $"The_Book_of_TOB\n" +
                                       $"back\n";

        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static string book01 = string.Empty;
        private static string book02 = string.Empty;
        private static string book03 = string.Empty;
        private static string book04 = string.Empty;
        private static string book05 = string.Empty;
        private static string book06 = string.Empty;
        private static string book07 = string.Empty;



        public Test_Selection10()
        {
            load_Selection01();
            book01 = File_M13.Book_of_Jasher_pdf;
            book02 = File_M13.Book_of_Jasher_pdf;
            book03 = File_M13.book_of_judith_pdf;
            book04 = File_M13.Dead_Sea_Scrolls_pdf;
            book05 = File_M13.The_Book_of_Enoch_pdf;
            book06 = File_M13.The_Book_of_Jubilees_pdf;
            book07 = File_M13.The_Book_of_TOB_pdf;
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

            string procedure = menu_array01[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {
                case "Book_of_Jasher":
                    _commands[procedure] = Book_of_Jasher;
                    break;
                case "book_of_judith":
                    _commands[procedure] = book_of_judith;
                    break;
                case "Dead_Sea_Scrolls":
                    _commands[procedure] = Dead_Sea_Scrolls;
                    break;
                case "The_Book_of_TOB":
                    _commands[procedure] = The_Book_of_TOB;
                    break;
                case "back":
                    _commands[procedure] = back;
                    break;

            }

        }
        private void Book_of_Jasher()
        {
            Console.WriteLine(book01);
        }
        private void book_of_judith()
        {
            Console.WriteLine(book02);
        }
        private void Dead_Sea_Scrolls()
        {
            Console.WriteLine(book03);
        }
        private void The_Book_of_TOB()
        {
            Console.WriteLine(book04);
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
