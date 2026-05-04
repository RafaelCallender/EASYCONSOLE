using EASY_CALLENDER01.SERVICES.AI_SERVICES.AI_TEXT_TO_TEXT;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_HELPER;
using EASY_CALLENDER01.SERVICES.LANGUAGE.LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
namespace EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_SELECTION_VIEW
{
    internal class Translate_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Language_Services01 Language_Serv01 = new Language_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static Language_Helper01 Language_H01 = new Language_Helper01();
        public Translate_Selection_View01()
        {
            load_Translate_Selection_View01().Wait();
        }
        private string load_Translate_Selection_View01_string()
        {
            return
           $"1.) Tranlate_Text\n" +
$"2.) Batch_Translation\n" +
$"3.) Translate_JSON\n" +
$"4.) Translate_HTML\n" +
$"5.) Detect_Language\n" +
$"6.) Supported_languages\n" +
$"7.) back\n";
        }
        private async Task load_Translate_Selection_View01()
        {

            Console.WriteLine(load_Translate_Selection_View01_string());
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
                                foreach (var a in Language_H01.language)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                data01[3] = $"{Language_H01.data_array01[1]}\n" +
                                    $"--------------------------------------------\n" +
                                    $"{data01[2]}";
                                Console.WriteLine(data01[3]);
                                data01[4] = Console.ReadLine() ?? string.Empty;

                                if (Security_Serv01.empty_string(data01[4], out data01[23]) == true)
                                {

                                    data01[5] = $"{Language_H01.data_array01[0]}";
                                    Console.WriteLine(data01[5]);
                                    data01[6] = Console.ReadLine() ?? string.Empty;

                                    if (Security_Serv01.empty_string(data01[6], out data01[23]) == true)
                                    {

                                        if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                                        {

                                            data01[7] = await Language_Serv01.Tranlate_Text(Language_H01.code[int.Parse(data01[4])].Trim(), data01[6].Trim());
                                            Console.WriteLine(data01[7]);
                                            Console.WriteLine(load_Translate_Selection_View01_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[24]);
                                            data01[6] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[23]);
                                        data01[6] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[4] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            case 2:
                                data01[7] = await Language_Serv01.Batch_Translation();
                                Console.WriteLine(data01[7]);
                                Console.WriteLine(load_Translate_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 3:
                                Console.WriteLine(await Language_Serv01.Translate_JSON());
                                Console.WriteLine(load_Translate_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 4:
                            
                                Console.WriteLine(await Language_Serv01.Translate_HTML());
                                Console.WriteLine(load_Translate_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 5:
                                Console.WriteLine($"{Language_H01.data_array01[0]}");
                                data01[6] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[6], out data01[23]) == true)
                                {


                                    data01[7] = await Language_Serv01.Detect_Language(data01[6].Trim());
                                    Console.WriteLine(data01[7]);
                                    Console.WriteLine(load_Translate_Selection_View01_string());
                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[6] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 6:
                                Console.WriteLine(await Language_Serv01.Supported_languages());
                                Console.WriteLine(load_Translate_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;

                            case 7:
                                new Translate_Main_View01();
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