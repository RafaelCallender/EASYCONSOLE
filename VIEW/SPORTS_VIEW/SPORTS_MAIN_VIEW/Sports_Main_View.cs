using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NBA_VIEW;
using EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NFL_VIEW;

namespace EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_MAIN_VIEW
{
    internal class Sports_Main_View
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Sports_Main_View()
        {
            load_Sports_Main_View();
        }
        private string load_Sports_Main_View_string()
        {
            return $"1.) NBA\n" +
                        $"2.) NFL\n" +
                        $"3.) go back\n";

        }
        private void load_Sports_Main_View()
        {

   
            Console.WriteLine(load_Sports_Main_View_string());
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {

                if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                                new Sports_Selection_View01();
                                break;
                            case 2:
                                new Sports_Selection_Nfl_View01();
                                break;
                            case 3:
                                Program.load_main();
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