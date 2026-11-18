using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection12
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string01 = $"video1\n" +
                                              $"back\n";

        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static File_Picker01 File_P01 = new File_Picker01();
        public Test_Selection12()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[20] += $"{i}.){menu_array01[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {
                case "video1":
                    _commands.Add(procedure, video1);
                    break;

                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;

            }

        }
        private async void video1()
        {
         /*   string downloadPath =
             "/home/swageteam101/Desktop/OneDrive/PROJECTS/EASYPROJECT01/EASY_CALLENDER01/FILES/VIDEOS";

            var youtubeDownloader =
                new YouTube_Downloader_Service01(downloadPath);

            string youtubeUrl =
                "https://www.youtube.com/watch?v=VIDEO_ID";

            try
            {
                string mp4File =
                    await youtubeDownloader.download_youtube_mp401(
                        youtubeUrl);

                Console.WriteLine("Video downloaded:");
                Console.WriteLine(mp4File);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
              Console.WriteLine("not yet developed");
        }


        private void back()
        {
            new Test_Main_View01();
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
                    int stringlength = menu_array01.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array01[selection].Trim();
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
