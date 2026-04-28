using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using System.Threading.Tasks;
namespace EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        public Test_Selection01()
        {
            load_Test_Selection01().Wait();
        }

        private string load_test_selection01_string()
        {
            return $"1.) File_H01.all_embedded_files\n" +
                        $"2.) File_H01.all_embedded_pdf\n" +
                        $"3.) File_H01.all_embedded_images\n" +
                        $"4.) File_H01.all_embedded_excel\n" +
                        $"5.) File_H01.all_embedded_gguf_models\n" +
                        $"6.) File_H01.all_embedded_python_files\n" +
                        $"7.) File_H01.find_python_exe\n" +
                        $"8.) File_H01.all_embedded_exe_files\n" +
                        $"9.) File_H01.find_all_files_in_project\n" +
                        $"10.) File_H01.find_default_single_face_images02\n" +
                        $"11.) File_H01.find_default_single_face_images03\n" +
                        $"12.) File_H01.find_default_group_face_images01\n" +
                        $"13.) File_H01.all_embedded_safetensors_models\n" +
                        $"14.) File_H01.all_text_to_text_gguf_models\n" +
                        $"15.) File_H01.all_text_to_image_gguf_models\n" +
                        $"16.) File_H01.all_text_to_image_safetensors_models\n" +
                        $"17.) File_H01.all_python_files\n" +
                        $"18.) all_text_to_text_gguf_models\n" +
                        $"19.) all_gguf_translate\n" +
                        $"20.) all_embedded_files01\n" +
                        $"21.) all_saved_audio\n" +
                        $"22.)all_embedded_Json_files\n" +
                        $"23.) all c# projects\n" +
                        $"24.) find_text_files\n" +
						$"25.) find_webb_files\n" +
                        $"26.) IMAGES\n" +
                        $"27.) go back";
        }   
        private async Task load_Test_Selection01()
        {

          

            Console.WriteLine(load_test_selection01_string());
            data01[1] = Console.ReadLine() ?? "";
            while (true)
            {
                if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:

                                data01[2] = $"{File_H01.all_embedded_files()}\n";
                                Console.WriteLine(data01[2]);
                
                              Console.WriteLine(load_test_selection01_string());data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 2:

                                data01[2] = $"{File_H01.all_embedded_pdf()}\n";
                                Console.WriteLine(data01[2]);
                    
                     Console.WriteLine(load_test_selection01_string());
                     data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 3:

                                data01[2] = $"{File_H01.all_embedded_images()}\n";      data01[1] = Console.ReadLine() ?? "";
                    
                                Console.WriteLine(data01[2]);
                
                                 Console.WriteLine(load_test_selection01_string());
                                 data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 4:

                                data01[2] = $"{File_H01.all_embedded_excel()}\n";
                                Console.WriteLine(data01[2]);
                        
                                 Console.WriteLine(load_test_selection01_string());
                                 data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 5:
foreach(var a in File_H01.all_text_to_text_gguf_models01())
{


                    data01[2] += $"{a}\n";  
}

                                Console.WriteLine($"one gguf files: {File_H01.all_text_to_text_gguf_models01()[0]}\n"+
                                               $"all gguf files: {data01[2]}");
            
                             Console.WriteLine(load_test_selection01_string());
                             data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 6:

                                data01[2] = $"{File_H01.all_embedded_python_files()}\n";
                                Console.WriteLine(data01[2]);

    
                         Console.WriteLine(load_test_selection01_string());
                         data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 7:

                                data01[2] = $"{File_H01.find_python_exe()}\n";
                                Console.WriteLine(data01[2]);

            
                                     Console.WriteLine(load_test_selection01_string());
                                     data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 8:

                                data01[2] = $"{File_H01.all_embedded_exe_files()}\n";
                                Console.WriteLine(data01[2]);

                         Console.WriteLine(load_test_selection01_string());
                         data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 9:

                                data01[2] = $"{File_H01.find_all_files_in_project()}\n";
                                Console.WriteLine(data01[2]);
                            
                             Console.WriteLine(load_test_selection01_string());
                             data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 10:
                                foreach (var a in File_H01.find_default_single_face_images02())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
                        
                             Console.WriteLine(load_test_selection01_string());
                             data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 11:
                                foreach (var a in await File_H01.find_default_single_face_images03())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
                         Console.WriteLine(load_test_selection01_string());
                         data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 12:
                                foreach (var a in File_H01.find_default_group_face_images01())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
                            
                         Console.WriteLine(load_test_selection01_string());
                         data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 13:

                                data01[2] = $"{File_H01.all_embedded_safetensors_models()}\n";
                                Console.WriteLine(data01[2]);
    
                             Console.WriteLine(load_test_selection01_string());
                             data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 14:
                                foreach (var a in File_H01.all_text_to_text_gguf_models01())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);

                                 Console.WriteLine(load_test_selection01_string());
                                 data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 15:
                                foreach (var a in File_H01.all_text_to_image_gguf_models())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);

                             Console.WriteLine(load_test_selection01_string());
                             data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 16:
                                foreach (var a in File_H01.all_text_to_image_safetensors_models())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
                                
                         Console.WriteLine(load_test_selection01_string());
                         data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 17:
                                foreach (var a in File_H01.all_python_files())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
                    
                             Console.WriteLine(load_test_selection01_string());
                             data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 18:
                                foreach (var a in File_H01.all_text_to_text_gguf_models())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
    
                                     Console.WriteLine(load_test_selection01_string());
                                     data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 19:
                                foreach (var a in File_H01.all_gguf_translate())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
                                data01[1] = Console.ReadLine() ?? "";
                                 Console.WriteLine(load_test_selection01_string());
                                break;
                            case 20:
                                foreach (var a in File_H01.all_saved_audio())
                                {
                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);

                         Console.WriteLine(load_test_selection01_string());
                         data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 21:
                                data01[2] = $"{File_H01.all_embedded_files01()}\n";
                                Console.WriteLine(data01[2]);
                                
                     Console.WriteLine(load_test_selection01_string());
                     data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 22:
                                data01[2] = $"{File_H01.all_embedded_json_files()}\n";
                                Console.WriteLine(data01[2]);
                                Console.WriteLine(load_test_selection01_string());
                                     data01[1] = Console.ReadLine() ?? "";
                     
                                break;
                            case 23:
                                data01[2] = $"{File_H01.find_cs_files()}\n";
                                Console.WriteLine(data01[2]);
                                Console.WriteLine(load_test_selection01_string());
                                     data01[1] = Console.ReadLine() ?? "";
                                continue;
                            case 24:
                                data01[2] = $"{File_H01.find_text_files()}\n";
                                Console.WriteLine(data01[2]);
                                Console.WriteLine(load_test_selection01_string());
                                     data01[1] = Console.ReadLine() ?? "";
                                continue;
								     case 25:
                                data01[2] = $"{File_H01.find_webb_files()}\n";
                                Console.WriteLine(data01[2]);

                                     Console.WriteLine(load_test_selection01_string());
                                     data01[1] = Console.ReadLine() ?? "";
                                break;
                            case 26:
                               foreach(var a in File_Helper01.images)
                                {

                                    data01[2] += $"{a}\n";
                                }

                                Console.WriteLine(data01[2]);
                                
                         Console.WriteLine(load_test_selection01_string());
                         data01[1] = Console.ReadLine() ?? "";
                                break;

                            case 27:
                                new Test_Main_View01();
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

