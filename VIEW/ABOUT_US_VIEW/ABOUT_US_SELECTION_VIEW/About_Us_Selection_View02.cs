using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASYCONSOLE.VIEW.ABOUT_US_VIEW.ABOUT_US_MAIN_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.ABOUT_US_VIEW.ABOUT_US_SELECTION_VIEW
{
    internal class About_Us_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string01 = $"call\n" +
                                        $"text\n" +
                                        $"email\n";
        private static string[] menu_array = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public About_Us_Selection_View02()
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
                case "call":
                    _commands.Add(procedure, call);
                    break;
                case "text":
                    _commands.Add(procedure, text);
                    break;
                case "email":
                    _commands.Add(procedure, email);
                    break;

            }

        }
        private void call()
        {
            Console.WriteLine(File_Manger01.Admin_text03.Trim());
        }
        private void text()
        {
            Console.WriteLine(File_Manger01.Admin_text03.Trim());
        }
        private void email()
        {
            Console.WriteLine(File_Manger01.Admin_text01.Trim());
        }
        private void go_back()
        {
            new About_Us_Main_View01();
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
