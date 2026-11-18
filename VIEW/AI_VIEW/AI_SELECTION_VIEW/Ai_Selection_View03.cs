using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AI_SERVICES.IMAGE_EDIT;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.IMAGE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_SELECTION_VIEW
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
        private static Device_Services01 Device_Serv01 = new Device_Services01();
        private static string menu_string = $"PhotoAnime\n" +
                                            $"go back\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);



        public Ai_Selection_View03()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {

                case "PhotoAnime":
                    _commands.Add(procedure, PhotoAnime);
                    break;
            }
        }
        private async void PhotoAnime()
        {
            Console.WriteLine("select photo");
            if (Security_Serv01.is_photo_selected_linux(out data01[2]) == true)
            {
                var res = await Security_Serv01.is_connected_to_netwrok_linux();
                if (res.success == true)
                {

                    data01[3] = await Image_Serv01.image_to_url(data01[2]);
                    data01[4] = await Ai_Image_E01.PhotoAnime(data01[3]);
                    data01[5] = Device_Serv01.launch_default_browser(data01[4]);
                    Console.WriteLine(data01[5]);
                }
                else
                {
                    Console.WriteLine(res.output);
                }
            }
            else
            {
                Console.WriteLine(data01[2]);
            }
        }
        private void go_back()
        {
            new Ai_Main_View01();
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
