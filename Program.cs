using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.COLORS_VIEW.COLORS_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.MOVIES_VIEW.MOVIES_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.NETWROK_VIEW.NETWORK_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.NEWS_VIEW.NEWS_MAIN;
using EASYPROJECT01.EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.STUIDO_VIEW.STUDIO_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.USER_VIEW.USER_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.LOCATION_VIEW.LOCATION_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.LINUX_VIEW.LINUX_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.DOCUMENT_VIEW.DOCUMENT_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.DEVICE_VIEW.DEVICE_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.LANGUAGE_VIEW.LANGUAGE_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.UPLOAD_VIEW.UPLOAD_MAIN_VIEW;
using EASYPROJECT01.EASYCONSOLE.VIEW.ABOUT_US_VIEW.ABOUT_US_MAIN_VIEW;

namespace EASYPROJECT01.EASYCONSOLE
{
    class Program
    {
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
        private static string[] data01 = new string[100];
        private static string menu_string = "Ai_Main_View01\n" +
                           "Client_View01\n" +
                           "Email_Main_View01\n" +
                           "Journal_Main_View01\n" +
                           "Life_Main_View01\n" +
                           "Movies_Main_View01\n" +
                           "Network_Main_View01\n" +
                           "News_Main_View01\n" +
                           "Science_Main_View01\n" +
                           "Sports_Main_View\n" +
                           "Studio_Main_View01\n" +
                           "Test_Main_View01\n" +
                           "Translate_Main_View01\n" +
                           "User_Main_View01\n" +
                           "Location_Main_View01\n" +
                           "Colors_Main_View01\n" +
                           "Linux_Main_View01\n" +
                           "Document_Main_View01\n" +
                           "Device_Main_View01\n" +
                           "Language_Main_View01\n" +
                           "upload_Main_View01\n" +
                           "About_Us_Main_View01\n" +
                           "exit\n";


        private static string[] menu_array = menu_string.Split("\n");

        static async Task Main(string[] args)
        {
            load_main();
        }

        static string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        public static void load_main()
        {
            Console.WriteLine(ShowMenu());
            data01[1] = Console.ReadLine() ?? string.Empty;
            while (true)
            {
                if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        for (int i = 0; i < menu_array.Length; i++)
                        {
                            switch (menu_array[int.Parse(data01[1])])
                            {
                                case "Ai_Main_View01":
                                    new Ai_Main_View01();
                                    break;
                                case "Client_View01":
                                    new Client_View01();
                                    break;
                                case "Email_Main_View01":
                                    new Email_Main_View01();
                                    break;
                                case "Journal_Main_View01":
                                    new Journal_Main_View01();
                                    break;
                                case "Life_Main_View01":
                                    new Life_Main_View01();
                                    break;
                                case "Movies_Main_View01":
                                    new Movies_Main_View01();
                                    break;
                                case "Network_Main_View01":
                                    new Network_Main_View01();
                                    break;
                                case "News_Main_View01":
                                    new News_Main_View01();
                                    break;
                                case "Science_Main_View01":
                                    new Science_Main_View01();
                                    break;
                                case "Sports_Main_View":
                                    new Sports_Main_View();
                                    break;
                                case "Studio_Main_View01":
                                    new Studio_Main_View01();
                                    break;
                                case "Test_Main_View01":
                                    new Test_Main_View01();
                                    break;
                                case "Translate_Main_View01":
                                    new Translate_Main_View01();
                                    break;
                                case "User_Main_View01":
                                    new User_Main_View01();
                                    break;
                                case "Location_Main_View01":
                                    new Location_Main_View01();
                                    break;
                                case "Colors_Main_View01":
                                    new Colors_Main_View01();
                                    break;
                                case "Linux_Main_View01":
                                    new Linux_Main_View01();
                                    break;
                                case "Document_Main_View01":
                                    new Document_Main_View01();
                                    break;
                                case "Device_Main_View01":
                                    new Device_Main_View01();
                                    break;
                                case "Language_Main_View01":
                                    new Language_Main_View01();
                                    break;
                                case "upload_Main_View01":
                                    new Upload_Main_View01();
                                    break;
                                case "About_Us_Main_View01":
                                    new About_Us_Main_View01();
                                    break;
                                case "exit":
                                    return;
                                default:
                                    Console.WriteLine(ShowMenu());
                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                    break;

                            }
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