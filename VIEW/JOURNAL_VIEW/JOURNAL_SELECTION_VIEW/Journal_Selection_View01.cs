using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_MAIN_VIEW;


namespace EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_SELECTION_VIEW
{
    internal class Journal_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Journal_Selection_View01()
        {
            load_Journal_Selection_View01().Wait();
        }
        private string load_Journal_Selection_View01_string()
        {
            return $"1.) Write Journal using sqlexpress\n" +
                   $"2.) go back";
        }
        private async Task load_Journal_Selection_View01()
        {

            Console.WriteLine(load_Journal_Selection_View01_string());
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


                                Console.WriteLine("not yet developed");
                                Console.WriteLine(load_Journal_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:
                                new Journal_Main_View01();
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

