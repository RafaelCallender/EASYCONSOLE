using EASY_CALLENDER01.SERVICES.AI_SERVICES.IMAGE_EDIT;
using EASY_CALLENDER01.SERVICES.DEVICE_SERVICES;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASY_CALLENDER01.SERVICES.IMAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW;
using System;

using System.Text;
namespace EASYCONSOLE.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View03
    {
        private string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Image_Edit02 Image_E02 = new Image_Edit02();
        private static Image_Services01 Image_Serv01 = new Image_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static File_Picker01 File_P01 = new File_Picker01();
        private static Ai_Image_Edit01 Ai_Image_E01 = new Ai_Image_Edit01();
        private static Device_Services01 Device_Serv01=new Device_Services01(); 
        public Ai_Selection_View03()
        {
            load_Ai_Selection_View01().Wait();
        }
        private async Task load_Ai_Selection_View01()
        {
            data01[0] = $"1.) Upload Photo\n" +
                        $"2.) to go back\n";
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
                                data01[2] = File_P01.Filepicker_photo01();
                                if (File_H01.isphoto(data01[2]) == true)
                                {

                                    data01[3] = await Image_Serv01.image_to_url(data01[2]);
                                    data01[4] = await Ai_Image_E01.PhotoAnime(data01[3]);
                                    data01[5] = Device_Serv01.launch_default_browser(data01[4]);
                                    Console.WriteLine(data01[5]);
                                    return;

                                }
                                else
                                {
                                    data01[1] = "Input needs to be a photo. Please try again.";
                                    Console.WriteLine(data01[1]);
                                    data01[2] = File_P01.Filepicker_photo01();
                                    continue;
                                }
                            case 2:
                                new Ai_Main_View01();
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
