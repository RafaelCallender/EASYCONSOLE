using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW;


namespace EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW
{
    internal class Email_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Email_Main_View01()
        {
            load_Email_Main_View01();
        }
        private void load_Email_Main_View01()
        {

            data01[0] = $"1.) email using sql\n" +
                        $"2.) email using sqlite\n" +
                        $"3.) email using Mysql\n" +
                        $"4.) Send email\n" +
                        $"5.) go back\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {

                if (Security_Serv01.empty_string(data01[1],out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1],out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                                new Email_Selection_View01();
                                return;
                            case 2:
                                new Email_Selection_View02();
                                return;

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