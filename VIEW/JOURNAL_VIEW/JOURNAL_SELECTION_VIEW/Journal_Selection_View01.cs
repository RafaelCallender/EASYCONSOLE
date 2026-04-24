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
        private async Task load_Journal_Selection_View01()
        {

            data01[0] = $"1.) Write Journal\n" +
                        $"2.) go back";
  
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


                                Console.WriteLine("not yet developed");
                                return;
                                case 2:
                                new Journal_Main_View01();
                                return;

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

