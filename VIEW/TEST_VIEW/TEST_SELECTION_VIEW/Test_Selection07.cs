using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.SCIENCE_SERVICES.CHEMISTRY.CHEMISTRY_SERVICES;
namespace EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection07
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
		        private static File_Helper01 File_H01=new File_Helper01(); 
        private static Chemistry_Services03 Chemistry_Serv03=new Chemistry_Services03();  
        public Test_Selection07()
        {
            load_Test_Selection07();
        }
		private string load_Test_Selection07_string()
		{
			
			
			return      $"1.) sqlite build_connection_string01\n" +
       
						$"2.) back\n";

			
			
		}
        private void load_Test_Selection07()
        {


            Console.WriteLine(load_Test_Selection07_string());
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
                              Console.WriteLine("working on it");
							        Console.WriteLine(load_Test_Selection07_string());
							      data01[1] = Console.ReadLine() ?? string.Empty;
                                 break;
      
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