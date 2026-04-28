using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SQLITE;

namespace EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_Selection_View06
    {

        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Sqlite01 Language_Sql01 = new Language_Sqlite01()           ;

        public Translate_Selection_View06()
        {
            load_Translate_Selection_View06();
        }

        private string load_Translate_Selection_View06_string()
        {


            return $"1.) update_language_sqlite\n" +             
                        $"2.) go back\n";
        }

        private void load_Translate_Selection_View06()
        {


            Console.WriteLine(load_Translate_Selection_View06_string());
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


                                    Console.WriteLine(Language_Sql01.update_language_sqlite());
                                    Console.WriteLine(load_Translate_Selection_View06_string());
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