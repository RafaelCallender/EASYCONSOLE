using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.NEWS_VIEW.NEWS_SELECTION_VIEW;


namespace EASYCONSOLE.VIEW.NEWS_VIEW.NEWS_MAIN
{
    internal class News_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public News_Main_View01()
        {
            load_News_Main_View01();
        }
        private void load_News_Main_View01()
        {

            data01[0] = $"1.) News 01\n" +
                        $"2.) go back";
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
                                new News_Selection_View01();
                                break;
                            case 2:
                                
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