using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.COLORS_VIEW.COLORS_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.COLORS.COLORS_HELPER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LOGIN_VIEW.LOGIN_SELECTION_VIEW
{
    internal class Login_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Colors_Helper01 Colors_H01 = new Colors_Helper01();
        private static string menu_string = $"Sign in User\n" +
                                            $"Sign in owner\n" +
                                            $"go back\n";

        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Login_Selection_View01()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {
                case "Sign in User":
                    _commands[procedure] = Sign_in_User;
                    break;

                case "Sign in owner":
                    _commands[procedure] = Sign_in_owner;
                    break;
                case "go back":
                    _commands[procedure] = go_back;
                    break;

            }

        }
        private void Sign_in_User()
        {
            Console.WriteLine($"username");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[30]) == true)
            {
                Console.WriteLine($"Password");
                data01[3] = Console.ReadLine();
                if (Security_Serv01.empty_string(data01[3], out data01[31]) == true)
                {
                    Console.WriteLine($"not yet developed");
                }
                else
                {
                    Console.WriteLine(data01[31]);
                }
            }
            else
            {
                Console.WriteLine(data01[30]);
            }

        }
        private void Sign_in_owner()
        {
            Console.WriteLine($"not yet developed");
        }
        private void go_back()
        {
            return;
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
