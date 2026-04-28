using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_SELECTION_VIEW;

namespace EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_MAIN_VIEW
{
    internal class Science_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Science_Main_View01()
        {
            load_Science_Main_View01();
        }
        private string load_Science_Main_View01_string()
        {
return $"1.) Chemistry using textfiles \n" +
                        $"2.) Chemistry using sql express \n" +
                        $"3.) Chemistry using sqlite \n" +
                        $"4.) Chemistry using Mysql \n" +
                        $"5.) Nasa\n" +
                        $"6.) go back\n";


        }
        private void load_Science_Main_View01()
        {

            Console.WriteLine(load_Science_Main_View01_string());
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
                                new Science_Selection_View01();
                                break;
                            case 2:
                                  new Science_Selection_View02();
                                break;
case 3:
		      new Science_Selection_View03();
                                break;
                                case 4:
		      new Science_Selection_View04();
                                break;
                                case 5:
		      Console.WriteLine("not yet develop");
     Console.WriteLine(load_Science_Main_View01_string());
            data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                                case 6:
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