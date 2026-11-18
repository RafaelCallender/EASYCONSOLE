using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.DOCUMENT_VIEW.DOCUMENT_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.DOCUMENT_VIEW.DOCUMENT_SELECTION_VIEW
{
    internal class Document_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static File_Picker01 File_P01 = new File_Picker01();
        private static File_Manger13 File_M13 = new File_Manger13();
        private static File_Servicesr01 File_S01 = new File_Servicesr01();
        private static string menu_string = $"upload file\n" +
                                            $"upload file 01\n" +
                                             $"go back";

        private static string[] menu_array = menu_string.Split("\n");

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);


        public Document_Selection_View01()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.){menu_array[i]}\n";
            }
            return data01[20];
        }

        private void load_Selection_data01()
        {

            string procedure = menu_array[int.Parse(data01[1])].Trim();
            switch (procedure)
            {
                case "upload file":
                    _commands.Add(procedure, upload_file);
                    break;
                case "upload file 01":
                    _commands.Add(procedure, upload_file_01);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
            }

        }
        private void upload_file()
        {
            if (File_P01.FilePickerLinux02(data01[2], out data01[25]) == true)
            {
                if (File_S01.Read_Document01(data01[25], out data01[26]))
                {
                    Console.WriteLine(data01[26]);
                }
                else
                {
                    Console.WriteLine(data01[26]);
                }
            }
            else
            {
                Console.WriteLine(data01[25]);
            }

        }
        private void upload_file_01()
        {
            Console.WriteLine("only for web and mobile");


        }
        private void go_back()
        {
            new Document_Main_View01();
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
                    int stringlength = menu_array.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array[selection].Trim();
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
            else
            {
                Console.WriteLine(data01[23]);

            }
        }
    }
}

