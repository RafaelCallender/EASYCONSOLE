using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.MOVIES_VIEW.MOVIES_SELECTION_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.MOVIES_VIEW.MOVIES_MAIN_VIEW
{
    internal class Movies_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"movie list sqlexpress\n" +
                         $"movie list sqlite\n" +
                         $"movie list MySql\n" +
                         $"go back";
        private static string[] menu_array = menu_string.Split("\n");
        public Movies_Main_View01()
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

                            case "movie list sqlexpress":
                                new Movies_Selection_View01();
                                break;
                            case "movie list sqlite":
                                Console.WriteLine("not developed yet");
                                continue;
                            case "movie list MySql":
                                Console.WriteLine("not developed yet");
                                continue;
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