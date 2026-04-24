using EASY_CALLENDER01.SERVICES.EMAIL_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW;


namespace EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW
{
    internal class Email_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Email_Services01 Email_S01 = new Email_Services01();
        public Email_Selection_View02()
        {
            load_Email_View01();
        }
        private void load_Email_View01()
        {

            data01[0] = $"1.) send email\n" +
                        $"2.) go back\n";
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
                                string res = string.Empty;
                                data01[2] = "enter email address";
                                Console.WriteLine(data01[2]);
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3],out data01[23]) == true)
                                {
                                    if (Security_Serv01.email_check(data01[3],out data01[24]) == true)
                                    {
                                        data01[4] = $"enter naem";
                                        Console.WriteLine(data01[4]);
                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[5],out data01[23]) == true)
                                        {
                                            data01[6] = $"Enter Your message";
                                            Console.WriteLine(data01[6]);
                                            data01[7] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[7],out data01[23]) == true)
                                            {
                                              
                                                if (Email_S01.send_email(data01[3], data01[5], data01[6], data01[7],out res) == true)
                                                {
                                                    data01[8] = res;
                                                    Console.WriteLine(data01[8]);
                                                    return;
                                                }
                                                else
                                                {
                                                    data01[8] = res;
                                                    Console.WriteLine(data01[8]);
                                                    continue;
                                                }
                                     

                                            }
                                            else
                                            {
                                             
                                                Console.WriteLine(data01[24]);
                                                data01[7] = Console.ReadLine() ?? string.Empty;
                                                continue;


                                            }


                                        }

                                        else
                                        {
                                           
                                            Console.WriteLine(data01[23]);
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }





                                    }
                                    else
                                    {
                                     
                                        Console.WriteLine(data01[23]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }


                                }
                                else
                                {
                                 
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 2:
                                new Email_Main_View01();
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