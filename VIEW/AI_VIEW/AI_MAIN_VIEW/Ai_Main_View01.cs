using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYCONSOLE.VIEW.AI_VIEW.AI_SELECTION_VIEW;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW
{
    internal class Ai_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        public Ai_Main_View01()
        {
            load_Ai_Main_View01();
        }
        private void load_Ai_Main_View01()
        {

            data01[0] = $"1.) change hairstyle\n" +
                        $"2.) Ai text generation\n" +
                        $"3.) Edit Image 01\n" +
                        $"4.) text to image generation\n" +
                        $"5.) go back\n";
            Console.WriteLine(data01[0]);
            data01[1] = Console.ReadLine() ?? string.Empty;

            while (true)
            {
                if (Security_Serv01.empty_string(data01[1],out data01[23]) == true)
                {
                    if (Security_Serv01.string_only_digit(data01[1],out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:
                                new Ai_Selection_View01();
                                break;
                            case 2:
                                new Ai_Selection_View02();
                                return;
                                case 3:
                                    new Ai_Selection_View03();
                                                                break;
                            case 4:
                                new Ai_Selection_View04();
                                                                break;
                                case 5:
								Program.load_main();
								 break;
                               
                           

                        }
                    }
                    else
                    {
               
                        data01[2] = data01[24];
                        Console.WriteLine(data01[2]);
                        data01[1] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
                else
                {
          
                    data01[2] = data01[23];
                    Console.WriteLine(data01[2]);
                    data01[1] = Console.ReadLine() ?? string.Empty;
                    continue;
                }


            }

        }
    }
}