using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW;
namespace EASYPROJECT01.EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW
{
    internal class Email_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"email using sql\n" +
                        $"email using sqlite\n" +
                        $"email using Mysql\n" +
                        $"send email\n" +
                        $"go back\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Email_Main_View01()
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


                case "email using sql":
                    _commands.Add(procedure, email_using_sql);
                    break;
                case "email using sqlite":
                    _commands.Add(procedure, email_using_sqlite);
                    break;
                case "email using Mysql":
                    _commands.Add(procedure, email_using_Mysql);
                    break;
                case "send email":
                    _commands.Add(procedure, send_email);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
            }
        }
        private void email_using_sql()
        {
            new Email_Selection_View01();
        }
        private void email_using_sqlite()
        {
            new Email_Selection_View02();
        }
        private void email_using_Mysql()
        {
            new Email_Selection_View03();
        }
        private void send_email()
        {
            new Email_Selection_View04();
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
