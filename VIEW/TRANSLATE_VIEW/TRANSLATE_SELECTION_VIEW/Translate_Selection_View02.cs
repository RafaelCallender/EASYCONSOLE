using EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using System;
using System.Collections.Generic;
using System.Text;

namespace EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Services01 Language_S01 = new Language_Services01();
        private static Language_Services02 Language_S02 = new Language_Services02();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static Audio_Services02 Audio_S02 = new Audio_Services02();
        public Translate_Selection_View02()
        {
            load_Translate_Selection_View02().Wait();
        }
        private async Task load_Translate_Selection_View02()
        {

            data01[0] = $"1.) Translate Text\n" +
                $"2.) Translate_image\n" +
                $"3.) Translate_speech\n" +
                $"4.) Bulk_translate_text\n" +
                $"5.) go back\n";

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

                                foreach (var a in Language_S01.language)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                data01[3] = $"{Language_S01.data_array01[1]}\n" +
                                    $"--------------------------------------------\n" +
                                    $"{data01[2]}";
                                Console.WriteLine(data01[3]);
                                data01[4] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[4], out data01[23]) == true)
                                {



                                    data01[5] = $"{Language_S01.data_array01[0]}";
                                    Console.WriteLine(data01[5]);
                                    data01[6] = Console.ReadLine() ?? string.Empty;

                                    if (Security_Serv01.empty_string(data01[6], out data01[23]) == true)
                                    {




                                        /*   data01[7] = $"language selected: {Language_S01.language[int.Parse(data01[4])]}\n" +
                                                        $"text: {data01[6]}\n";*/


                                        data01[7] = await Language_S02.Translate_text(Language_S01.language[int.Parse(data01[4])].Trim(), data01[6].Trim());
                                        Console.WriteLine(data01[7]);
                                        data01[6] = Console.ReadLine() ?? string.Empty;
                                        return;


                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[23]);
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
                            case 2:


                                data01[4] = $"Recording started. Press Enter to stop...\n" +
                                            $"{Audio_S02.record_voice()}";




                                Console.WriteLine(data01[4]);
                         




                                break;
                            case 3:
                                new Translate_Main_View01();
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