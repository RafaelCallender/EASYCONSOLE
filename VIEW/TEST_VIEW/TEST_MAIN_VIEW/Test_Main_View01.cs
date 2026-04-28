using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;

namespace EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW
{
    internal class Test_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        public Test_Main_View01()
        {
            load_test_view();
        }
        private string load_test_view_string()
        {
            return $"1.) files 01\n" +
                        $"2.) text files\n" +
                        $"3.) movies files\n" +
                        $"4.) sqlexpress search\n" +
                        $"5.) user question textfiles \n" +
                        $"6.) Mysql search\n" +
						$"7.) sqlite search\n" +						
						$"8.) back\n";
        }
        private void load_test_view()
        {

       
            Console.WriteLine(load_test_view_string());
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
                                new Test_Selection01();
                                 break;
                            case 2:
                                new Test_Selection02();
                                   break;
                            case 3:
                                new Test_Selection03();
                                   break;
                            case 4:
                                new Test_Selection04();
                                   break;
                            case 5:
                        		new Test_Selection05();
                                break;
                                     case 6:
                        		new Test_Selection06();
                                break;
                                     case 7:
                        		new Test_Selection07();
                                break;
                                     case 8:
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