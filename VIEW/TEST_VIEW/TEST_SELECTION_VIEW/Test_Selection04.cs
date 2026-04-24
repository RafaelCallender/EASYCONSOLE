using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using EASY_CALLENDER01.SERVICES.LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.SQL_SERVICES.SQL_HELPER;
namespace EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection04
    {


        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
        private static Sql_Helper01 Sql_H01 = new Sql_Helper01();
        //  private static Language_Services01 Language_Serv01 = new Language_Services01();

        public Test_Selection04()
        {
            load_Test_Selection04();
        }
        private string load_Test_Selection04_string()
        {
            return  $"1.) built sql server \n" +
                    $"2.) sql sections \n" +
                    $"3.) built sql server 01 \n" +
                    $"4.) Back \n";
        }
        private void load_Test_Selection04()
        {



            Console.WriteLine(load_Test_Selection04_string());
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

                                data01[2] = Sql_H01.build_connection_string01(
            (int)Sql_Helper01.connectionStringdatabase.Chemistry_Database,
            (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
            true);
                            

                                Console.WriteLine(data01[2]);
                                   Console.WriteLine(load_Test_Selection04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;



                            case 2:
                                int number = (int)Sql_Helper01.connectionStringServer.SqlExpress_server;

                                data01[2] = number.ToString();



                                Console.WriteLine(data01[2]);
                                   Console.WriteLine(load_Test_Selection04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                           break;


                            case 3:

                                
                                data01[2] = Sql_H01.build_connection_string02(
            (int)Sql_Helper01.connectionStringServer.SqlExpress_server,
            (int)Sql_Helper01.connectionStringdatabase.Chemistry_Database,
            true);
                                ;

                                Console.WriteLine(data01[2]);
                                   Console.WriteLine(load_Test_Selection04_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;

                                break;
                            case 4: 
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