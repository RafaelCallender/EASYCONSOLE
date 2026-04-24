using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.TEXT_FILES;
using EASY_CALLENDER01.SERVICES.LANGUAGE_SERVICES;
using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
namespace EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
      //  private static Language_Services01 Language_Serv01 = new Language_Services01();
      
        public Test_Selection02()
        {
            load_Test_Selection02();
        }
		private string Test_Selection_List()
		{
			
			return   $"1.) admin_path01\n" +
        $"2.)API\n" +
        $"3.) Chemistry\n" +
        $"4.) Chemistry01\n" +
        $"5.) Client_Textfile01\n" +
        $"6.) cloudinary_com\n" +
        $"7.) hairstyle_info_01\n" +
        $"8.) hairstyle_info_02\n" +
        $"9.) Language_Abbreviation\n" +
        $"10.) Language_Name\n" +
        $"11.) The_Book_of_Enoch\n" +
        $"12.) The_Book_of_Jubilees\n" +
        $"13.) The_Bible_KJV\n" +
        $"14.) back\n";
			
		}
        private void load_Test_Selection02()
        {

    

            Console.WriteLine(Test_Selection_List());
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

                                data01[2] += $"{Read_T01.admin_path01}\n";

                                Console.WriteLine(data01[2]);
			    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:

                                foreach (var a in Read_T01.API)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
								       Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 3:

                                foreach (var a in Read_T01.Chemistry)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 4:

                                foreach (var a in Read_T01.Chemistry01)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 5:


                                data01[2] += Read_T01.Client_Textfile01;
                                
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 6:

                                foreach (var a in Read_T01.cloudinary_com)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 7:

                                foreach (var a in Read_T01.hairstyle_info_01)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 8:

                                foreach (var a in Read_T01.hairstyle_info_02)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 9:

                                foreach (var a in Read_T01.Language_Abbreviation)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
                           	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;

                            case 10:
                                foreach (var a in Read_T01.Language_Name)
                                {
                                    data01[2] += $"{a}\n";
                                }
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 11:
                              data01[2] = Read_T01.The_Book_of_Enoch;
                                Console.WriteLine(data01[2]);       
								    Console.WriteLine(Test_Selection_List());
                            	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 12:
                                data01[2] = Read_T01.The_Book_of_Jubilees;
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
                                	    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 13:
                                data01[2] = Read_T01.The_Bible_KJV;
                                Console.WriteLine(data01[2]);
								    Console.WriteLine(Test_Selection_List());
							    data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 14:
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

