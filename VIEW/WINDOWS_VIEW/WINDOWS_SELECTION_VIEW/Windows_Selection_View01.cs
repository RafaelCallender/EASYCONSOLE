using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.WINDOWS_VIEW.WINDOWS_MAIN_VIEW;


namespace EASYPROJECT01.EASYCONSOLE.VIEW.WINDOWS_VIEW.WINDOWS_SELECTION_VIEW
{
    internal class Windows_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Windows_Selection_View01()
        {
            load_Windows_Selection_View01();
        }

        private string load_Windows_Selection_View01_string()
        {
            return $"1.)update onedrive\n" +

                                    $"2.) go back";
        }
        private void load_Windows_Selection_View01()
        {

            Console.WriteLine(load_Windows_Selection_View01_string());
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
                                Console.WriteLine(load_Windows_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:
                                new Windows_Main_View01();
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