using EASYPROJECT01.EASYCONSOLE.VIEW.INDEX_VIEW.INDEX_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
namespace EASYPROJECT01.EASYCONSOLE
{
    class Program
    {
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string[] data01 = new string[100];
        private static string menu_string ="Easy Callender\n" +
                                                        "exit\n";


        private static string[] menu_array = menu_string.Split("\n");

        static async Task Main(string[] args)
        {
            load_main();
        }

        static string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        public static void load_main()
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
                            case "Easy Callender":
                                new Index_Main_View01();
                                break;
                            case "exit":
                                return;
                            default:
                                Console.WriteLine(ShowMenu());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;

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