using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.USER_VIEW.USER_SELECTION_VIEW;


namespace EASYCONSOLE.VIEW.USER_VIEW.USER_MAIN_VIEW
{
    internal class User_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public User_Main_View01()
        {
            load_User_Main_View01();
        }

       private string load_User_Main_View01_string()
        {
            return $"1.) User data using sqlexpress \n" +
                        $"2.) User data using sqlite\n" +
                        $"3.) User data using MYsql\n" +           
                        $"4.) go back";
        }
        private void load_User_Main_View01()
        {

        
            Console.WriteLine(load_User_Main_View01_string());
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
                                new User_Selection_View01();
                                break;
                            case 2:
                                new User_Selection_View02();
                                break;
                            case 3:
                                new User_Selection_View03();
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