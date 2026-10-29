using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.UPLOAD_VIEW.UPLOAD_SELECTION_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.UPLOAD_VIEW.UPLOAD_MAIN_VIEW
{
    internal class Upload_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"upload file using sqlexpress\n" +
                        $"upload file using mysql\n" +
                        $"upload file using sqlite\n" +
                        $"go back\n";
        private static string[] menu_array = menu_string.Split("\n");
        public Upload_Main_View01()
        {
            load_Main_View01();
        }
        private string load_Upload_Main_View01_string()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Main_View01()
        {
            Console.WriteLine(load_Upload_Main_View01_string());
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

                                case "upload file using sqlexpress":
                                    new Upload_Selection_View01();
                                    break;
                                case "upload file using mysql":
                                    new Upload_Selection_View02();
                                    break;
                                case "upload file using sqlite":
                                    new Upload_Selection_View03();
                                    break;
                                case "go back":
                                    Program.load_main();
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