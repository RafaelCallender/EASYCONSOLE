using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;
using EASY_CALLENDER01.SERVICES.COLORS.COLORS_HELPER;
namespace EASYCONSOLE.VIEW.COLORS_VIEW.COLORS_SELECTION_VIEW
{
    internal class Colors_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Colors_Helper01 Colors_H01 = new Colors_Helper01();

        private string resaults = string.Empty;
        public Colors_Selection_View01()
        {
            load_Colors_Selection_View01();
        }
        private string load_Colors_Selection_View01_String()
        {
            return $"1.)get colors\n" +
                    $"2.) go back\n";


        }
        private void load_Colors_Selection_View01()
        {
            Console.WriteLine(load_Colors_Selection_View01_String());
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


                                Console.WriteLine($"{string.Join("\n",Colors_H01.color_Name)}");
                                break;
                            case 2:
                                new Client_View01();
                                break;  

                        }
                    }
                    else
                    {
                        Console.WriteLine(data01[24]); Console.WriteLine(data01[23]);
                        data01[1] = Console.ReadLine() ?? string.Empty;
                        continue;
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
