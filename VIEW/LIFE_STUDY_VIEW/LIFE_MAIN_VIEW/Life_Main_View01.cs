using System;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_SELECTION_VIEW;


namespace EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW
{
    internal class Life_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Life_Main_View01()
        {
            load_Life_Main_View01();
        }
        private void load_Life_Main_View01()
        {

            data01[0] = $"1.) The Bible\n" +
                        $"2.) The Book of Enoch.\n" +
                        $"3.) The Book of Jubilees\n" +
                        $"4.)all Books\n" +
                        $"5.) go back\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;
            while (true)
            {
                if (Security_Serv01.empty_string(data01[1],out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                                new Life_Selection_View01();
                                return;
                            case 2:
                                new Life_Selection_View02();
                                return;
                            case 3:

                                if (OperatingSystem.IsWindows())
                                {
                                    var view = new Life_Selection_View03();
                                    return;
                                }
                                else
                                {
                                    data01[2] = "Option 3 (The Book of Jubilees) is only supported on Windows.";
                                    Console.WriteLine(data01[2]);
                                    continue;
                                }
                           
                            case 4:
                                new Life_Selection_View04();
                                return;
                            case 5:
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