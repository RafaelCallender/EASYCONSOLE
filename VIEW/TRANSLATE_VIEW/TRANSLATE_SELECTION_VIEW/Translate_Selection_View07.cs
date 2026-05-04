using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_MYSQL;        

namespace EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_Selection_View07
    {
private static string[] data01 = new string[100];       
        private static Language_Mysql01 Language_My01 = new Language_Mysql01();
      private static Security_Services01 Security_Serv01 = new Security_Services01();
        public Translate_Selection_View07()
        {
            load_Translate_Selection_View07_string();
        }

        private string load_Translate_Selection_View07_string()
        {


            return $"1.) mysql 01\n" +
                        $"2.) go back\n";
        }

        private void load_Translate_Selection_View07()
        {


            Console.WriteLine(load_Translate_Selection_View07_string());
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


                                Console.WriteLine("working in progress");
                                Console.WriteLine(load_Translate_Selection_View07_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
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