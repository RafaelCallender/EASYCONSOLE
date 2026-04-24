using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW;

namespace EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW
{
    internal class Translate_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Translate_Main_View01()
        {
            load_Translate_Main_View01();
        }
        private void load_Translate_Main_View01()
        {

            data01[0] = $"1.) Translate Text 01\n" +
                        $"2.) Translate Text 02\n" +
                        $"3.) Translate text using AI\n" +
                        $"4.) go back\n";
            Console.WriteLine(data01[0]);
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
                                new Translate_Selection_View01();
                                break;
                            case 2:
                                new Translate_Selection_View02();
                                break;
                            case 3:
                                new Translate_Selection_View03();
                                break;
                            case 4:
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