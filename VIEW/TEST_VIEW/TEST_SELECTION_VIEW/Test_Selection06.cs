using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.MYSQL_SERVICES.MYSQL_HELPER;
namespace EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection06
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
		        private static File_Helper01 File_H01=new File_Helper01(); 
                	private static MySql_Helper01 MySql_H01=new MySql_Helper01();
        public Test_Selection06()
        {
            load_Test_Selection06();
        }
		private string load_Test_Selection06_string()
		{
			
			
			return      $"1.) Mysql build_connection_string01\n" +
       
						$"2.) back\n";

			
			
		}
        private void load_Test_Selection06()
        {


            Console.WriteLine(load_Test_Selection06_string());
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
                              Console.WriteLine(MySql_H01.build_connection_string01(
            (int)MySql_Helper01.connectionStringServer.MySql_server,
            (int)MySql_Helper01.connectionStringUser.root,
            (int)MySql_Helper01.connectionStringdatabase.Clients01_Database,
            true));
							        Console.WriteLine(load_Test_Selection06_string());
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