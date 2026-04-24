using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW;
using EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW;
using EASYCONSOLE.VIEW.LIFE_STUDY_VIEW.LIFE_STUDY_MAIN_VIEW;
using EASYCONSOLE.VIEW.MOVIES_VIEW.MOVIES_MAIN_VIEW;
using EASYCONSOLE.VIEW.NETWROK_VIEW.NETWORK_MAIN_VIEW;
using EASYCONSOLE.VIEW.NEWS_VIEW.NEWS_MAIN;
using EASYCONSOLE.VIEW.SCIENCE_VIEW.SCIENCE_MAIN_VIEW;
using EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_MAIN_VIEW;
using EASYCONSOLE.VIEW.STUIDO_VIEW.STUDIO_MAIN_VIEW;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYCONSOLE.VIEW.TRANSLATE_VIEW.TRANSLATE_MAIN_VIEW;
using EASYCONSOLE.VIEW.USER_VIEW.USER_MAIN_VIEW;
using EASYCONSOLE.VIEW.JOURNAL_VIEW.JOURNAL_MAIN_VIEW;	
namespace EASYCONSOLE
{
    class Program
    {
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Helper01 File_H01 = new File_Helper01();
		  private static string[] data01 = new string[100];
        static async Task Main(string[] args)
        {
         load_main();
		   
		}

 static string ShowMenu()
{
    return "1.) Ai_Main_View01\n" +
           "2.) Client_View01\n" +
           "3.) Email_Main_View01\n" +
           "4.) Journal_Main_View01\n" +
           "5.) Life_Main_View01\n" +
           "6.) Movies_Main_View01\n" +
           "7.) Network_Main_View01\n" +
           "8.) News_Main_View01\n" +
           "9.) Science_Main_View01\n" +
           "10.) Sports_Main_View\n" +
           "11.) Studio_Main_View01\n" +
           "12.) Test_Main_View01\n" +
           "13.) Translate_Main_View01\n" +
           "14.) User_Main_View01\n" +
           "0.) exit\n";
}
		public static void load_main()
		{
			Console.WriteLine(ShowMenu());
            data01[1] = Console.ReadLine() ?? string.Empty;
            while (true) 
            {

                if (Security_Serv01.empty_string(data01[1],out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
			
			 case 0:
 return;
 case 1:
new Ai_Main_View01();
 break;
 case 2:
new Client_View01();
 break;
 case 3:
new Email_Main_View01();
 break;
 case 4:
new Journal_Main_View01();
 break;
 case 5:
new Life_Main_View01();
 break;
 case 6:
new Movies_Main_View01();
 break;
 case 7:
new Network_Main_View01();
 break;
 case 8:
new News_Main_View01();
 break;
 case 9:
new Science_Main_View01();
 break;
 case 10:
new Sports_Main_View();
 break;
 case 11:
new Studio_Main_View01();
 break;
 case 12:
new Test_Main_View01(); 
 break;
 case 13:
new Translate_Main_View01();
 break;
 case 14:
new User_Main_View01();
break;

case > 15:

	Console.WriteLine(ShowMenu());
            data01[1] = Console.ReadLine() ?? string.Empty;
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