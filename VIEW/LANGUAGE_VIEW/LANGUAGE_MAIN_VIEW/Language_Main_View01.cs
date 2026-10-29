using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.LANGUAGE_VIEW.LANGUAGE_SELECTION_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LANGUAGE_VIEW.LANGUAGE_MAIN_VIEW
{
    internal class Language_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"Language sqlexperss\n" +
                 $"Language sqlite\n" +
                 $"Language Mysql\n" +
                 $"go back\n";
        private static string[] menu_array = menu_string.Split("\n");

        public Language_Main_View01()
        {
            load_Main_View01();
        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Main_View01()
        {
            Console.WriteLine(ShowMenu());
            data01[1] = Console.ReadLine() ?? string.Empty;
            while (true)
            {
                if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        switch (menu_array[int.Parse(data01[1])])
                        {

                            case "Language sqlexperss":
                                new Language_Selection_View01();
                                break;
                            case "Language sqlite":
                                new Language_Selection_View02();
                                break;
                            case "Language Mysql":
                                new Language_Selection_View03();
                                break;
                            case "go back":
                                Program.load_main();
                                break;
                            default:
                                Console.WriteLine(ShowMenu());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                continue;
                        }
                    }
                    else
                    {

                        Console.WriteLine(data01[24]);
                        data01[1] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine(data01[23]);
                    data01[1] = Console.ReadLine() ?? string.Empty;
                    continue;

                }
            }
        }
    }
}