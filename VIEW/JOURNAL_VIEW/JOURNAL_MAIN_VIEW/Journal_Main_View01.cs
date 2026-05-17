using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_SELECTION_VIEW;

namespace EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_MAIN_VIEW
{
    internal class Journal_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Journal_Main_View01()
        {
            load_Journal_Main_View01();
        }
        private string load_Journal_Main_View01_string()
        {
            return $"1.)Journal sqlexpress\n" +
                   $"2.)Journal sqlite\n" +
                   $"3.)Journal Mysql\n" +
                   $"4.) go back";
        }

        private void load_Journal_Main_View01()
        {


            Console.WriteLine(load_Journal_Main_View01_string());
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
                                new Journal_Selection_View01();
                                break;
                            case 2:
                                new Journal_Selection_View02();
                                break;
                            case 3:
                                new Journal_Selection_View03();
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