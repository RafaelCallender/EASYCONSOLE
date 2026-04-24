using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW;
using EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_HELPER;
using EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
namespace EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection05
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
		        private static File_Helper01 File_H01=new File_Helper01(); 
        public Test_Selection05()
        {
            load_test_view();
        }
		private string test_view_selection()
		{
			
			
			return      $"1.) mytextfile01\n" +
                        $"2.) mytextfile02\n" +
                        $"3.) mytextfile03\n" +
                        $"4.) mytextfile04\n" +
						$"5.) mytextfile05\n" +	
                    	$"6.) mytextfile06\n" +	
                    	$"7.) mytextfile07\n" +	
	                    $"8.) mytextfile08\n" +		
						$"9.) mytextfile09\n" +	
						$"9.) back\n";

			
			
		}
        private void load_test_view()
        {


            Console.WriteLine(test_view_selection());
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
                              Console.WriteLine(File_H01.find_text_files());
							        Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
                                 break;
                            case 2:
                         Console.WriteLine(File_H01.find_text_files);
							        Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
								  break;
                            case 3:
                     Console.WriteLine(File_H01.find_text_files);
							       Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
								  								  break;
                            case 4:
                        Console.WriteLine(File_H01.find_text_files);
							       Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
								  								  break;
                            case 5:
                       Console.WriteLine(File_H01.find_text_files);
							      Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
								  								  break;
								            case 6:
                      Console.WriteLine(File_H01.find_text_files);
							      Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
								  								  break;
										            case 7:
                              Console.WriteLine(File_H01.find_text_files);
				      Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
								  								  break;
										            case 8:
                         Console.WriteLine(File_H01.find_text_files);
				      Console.WriteLine(test_view_selection());
							      data01[1] = Console.ReadLine() ?? string.Empty;
								  break;
										            case 9:
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