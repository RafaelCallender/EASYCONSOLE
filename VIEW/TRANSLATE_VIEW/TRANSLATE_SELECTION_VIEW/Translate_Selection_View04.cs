using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_TEXTFILES;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;

namespace EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_Selection_View04
    {

        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Textfiles01 Language_T01 = new Language_Textfiles01();
        private static Language_Helper01 Language_H01 = new Language_Helper01();
        public Translate_Selection_View04()
        {
            load_Translate_Selection_View04();
        }

        private string load_Translate_Selection_View04_string()
        {


            return $"1.) view_language_using_text_file\n" +
                        $"2.) pick_languge_using_text_file\n" +
                        $"3.) go back\n";
        }

        private void load_Translate_Selection_View04()
        {


            Console.WriteLine(load_Translate_Selection_View04_string());
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
                                Console.WriteLine(Language_T01.view_language_using_text_file());
                                Console.WriteLine(load_Translate_Selection_View04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:


                                Console.WriteLine($"{Language_H01.data_array01[0]}");
                                data01[2] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[2], out data01[24]) == true)
                                    {

                                        Console.WriteLine(Language_T01.pick_languge_using_text_file(data01[2]));
                                        Console.WriteLine(load_Translate_Selection_View04_string());
                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                        break;
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
                                    data01[2] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

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