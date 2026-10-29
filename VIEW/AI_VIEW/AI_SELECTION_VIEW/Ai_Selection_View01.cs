using EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.IMAGE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.IMAGE_EDIT;


namespace EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_SELECTION_VIEW
{
    internal class Ai_Selection_View01
    {

        private string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Image_Edit02 Image_E02 = new Image_Edit02();
        private static Image_Services01 Image_Serv01 = new Image_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();

        private static Device_Services01 Device_Serv01 = new Device_Services01();

        private static string menu_string =
                                          "Hairstyle_Changer_Pro\n" +
                                                 "back\n";
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static string[] menu_array = menu_string.Split("\n");
        private static File_Picker01 File_P01 = new File_Picker01();

        public Ai_Selection_View01()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[40] += $"{i}.) {menu_array[i]}\n";
            }
            return data01[40];
        }
        private string ShowMenu01()
        {
            for (int i = 0; i < Image_E02.hairstyle_data02.Length; i++)
            {
                data01[41] += $"{i}.) {Image_E02.hairstyle_data02[i]}\n";

            }
            return data01[41];
        }
        private string ShowMenu02()
        {
            for (int i = 0; i < Image_E02.hairstyle_data03.Length; i++)
            {
                data01[42] += $"{i}.) {Image_E02.hairstyle_data03[i]}\n";

            }
            return data01[42];
        }
        private void load_Selection_data01()
        {
            string procedure = menu_array[int.Parse(data01[1])].Trim();
            switch (procedure)
            {
                case "Hairstyle_Changer_Pro":
                    _commands.Add(procedure, Hairstyle_Changer_Pro);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;
            }
        }

        private void back()
        {
             new Ai_Main_View01();
        }
        private async void Hairstyle_Changer_Pro()
        {
            Console.WriteLine("select photo");
            if (File_P01.filepickerlinux01(out data01[2]) == true)
            {
                if (Security_Serv01.isphoto(data01[2], out data01[23]) == true)
                {
                     Console.WriteLine("select hairstyle");
                     Console.WriteLine(ShowMenu01());
                    data01[3] = Console.ReadLine() ?? string.Empty;
                    if (Security_Serv01.empty_string(data01[3], out data01[24]) == true)
                    {
                        if (Security_Serv01.string_only_digit(data01[3], out data01[25]) == true)
                        {
                            Console.WriteLine("select hair color");
                            Console.WriteLine(ShowMenu02());
                            data01[4] = Console.ReadLine() ?? string.Empty;
                            if (Security_Serv01.empty_string(data01[4], out data01[26]) == true)
                            {
                                if (Security_Serv01.string_only_digit(data01[4], out data01[27]) == true)
                                {
                                    data01[5] = await Image_Serv01.image_to_url(data01[2]);
                                    data01[6] = await Image_E02.Hairstyle_Changer_Pro(int.Parse(data01[3]), int.Parse(data01[4]), data01[5]);
                                    //  data01[8] = Device_Serv01.launch_default_browser(data01[8]);
                                    data01[7] = $"{Image_E02.hairstyle_data02[int.Parse(data01[2])]}\n," +
                                                         $"{Image_E02.hairstyle_data03[int.Parse(data01[3])]}\n" +
                                                         $"{data01[4]}\n";

                                    Console.WriteLine(data01[6]);
                                }
                                else
                                {
                                    Console.WriteLine(data01[27]);
                                }
                            }
                            else
                            {
                                Console.WriteLine(data01[26]);
                            }

                        }
                        else
                        {
                            Console.WriteLine(data01[25]);
                        }

                    }
                    else
                    {
                        Console.WriteLine(data01[24]);
                    }


                }
                else
                {
                    Console.WriteLine(data01[23]);
                }
            }
            else
            {
                Console.WriteLine(data01[2]);
            }

        }
        private void load_Selection01()
        {
            Console.WriteLine(ShowMenu());
            data01[1] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                {
                    int selection = int.Parse(data01[1].Trim());
                    int stringlength = menu_array.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array[selection].Trim();
                        load_Selection_data01();
                        if (_commands.TryGetValue(key, out Action action))
                        {
                            action();
                            _commands.Clear();

                        }
                        else
                        {
                            Console.WriteLine($"{key} command not found");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }

                }
                else
                {
                    Console.WriteLine(data01[24]);

                }
            }
        }
    }
}
