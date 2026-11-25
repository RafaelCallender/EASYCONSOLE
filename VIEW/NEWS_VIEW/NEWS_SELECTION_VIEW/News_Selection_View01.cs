using EASYPROJECT01.EASY_CALLENDER01.SERVICES.NEWS_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.NEWS_VIEW.NEWS_MAIN;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.NEWS_VIEW.NEWS_SELECTION_VIEW
{
    internal class News_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static News_Services01 News_Serv01 = new News_Services01();
        private static string menu_string01 =
                   $"Real_Time_News_Data_GET_Search\n" +
                   $"Real_Time_News_Data_GET_Top_Headlines\n" +
                   $"Real_Time_News_Data_GET_Topic_Headlines\n" +
                   $"Real_Time_News_Data_GET_Topic_News_By_Section\n" +
                   $"Local_Headlines_Geo\n" +
                   $"Full_Story_Coverage\n" +
                   $"go back\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public News_Selection_View01()
        {
            load_Selection01();
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1])];
            switch (procedure)
            {

                case "Real_Time_News_Data_GET_Search":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Search);
                    break;
                case "Real_Time_News_Data_GET_Top_Headlines":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Top_Headlines);
                    break;
                case "Real_Time_News_Data_GET_Topic_Headlines":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Topic_Headlines);
                    break;
                case "Real_Time_News_Data_GET_Topic_News_By_Section":
                    _commands.Add(procedure, Real_Time_News_Data_GET_Topic_News_By_Section);
                    break;
                case "Local_Headlines_Geo":
                    _commands.Add(procedure, Local_Headlines_Geo);
                    break;
                case "Full_Story_Coverage":
                    _commands.Add(procedure, Full_Story_Coverage);
                    break;
                case "go_back":
                    _commands.Add(procedure, go_back);
                    break;


            }
        }

        private string ShowMenu()
        {
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[20] += $"{i}.){menu_array01[i]}\n";
            }
            return data01[20];
        }
        private async void Real_Time_News_Data_GET_Search()
        {
            data01[2] = $"{News_Serv01.data_array[1]}";
            Console.WriteLine(data01[2]);
            data01[3] = Console.ReadLine() ?? string.Empty;

            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                var res = await Security_Serv01.is_connected_to_netwrok_linux();
                if (res.success == true)
                {
                    data01[4] =await News_Serv01.Real_Time_News_Data_GET_Search(data01[3]);
                    Console.WriteLine(data01[4]);
                }
                else
                {

                    Console.WriteLine(res.output);
                }
            }

            else
            {
                Console.WriteLine(data01[23]);

            }

        }
        private async void Real_Time_News_Data_GET_Top_Headlines()
        {

            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                data01[4] = await News_Serv01.Real_Time_News_Data_GET_Top_Headlines();
                Console.WriteLine(data01[4]);
            }
            else
            {
                Console.WriteLine(res.output);
            }

        }
        private async void Real_Time_News_Data_GET_Topic_Headlines()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                data01[4] = await News_Serv01.Real_Time_News_Data_GET_Topic_Headlines();
                Console.WriteLine(data01[4]);
            }
            else
            {
                Console.WriteLine(res.output);
            }


        }
        private async void Real_Time_News_Data_GET_Topic_News_By_Section()
        {
            data01[2] = $"{News_Serv01.data_array[0]}";
            Console.WriteLine(data01[2]);
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                var res = await Security_Serv01.is_connected_to_netwrok_linux();
                if (res.success == true)
                {
                    data01[4] = await News_Serv01.Real_Time_News_Data_GET_Topic_News_By_Section(data01[3]);
                    Console.WriteLine(data01[4]);
                }
                else
                {
                    Console.WriteLine(res.output);
                }



            }
            else
            {

                Console.WriteLine(data01[23]);

            }

        }
        private async void Local_Headlines_Geo()
        {
            data01[2] = $"{News_Serv01.data_array[0]}";
            Console.WriteLine(data01[2]);
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                var res = await Security_Serv01.is_connected_to_netwrok_linux();
                if (res.success == true)
                {
                    data01[4] = await News_Serv01.Local_Headlines_Geo(data01[3]);
                    Console.WriteLine(data01[4]);
                }
                else
                {
                    Console.WriteLine(res.output);
                }
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }
        private async void Full_Story_Coverage()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                data01[4] = News_Serv01.Full_Story_Coverage().GetAwaiter().GetResult();
                Console.WriteLine(data01[4]);
            }
            else
            {

                Console.WriteLine(res.output);
            }

        }
        private void go_back()
        {
            new News_Main_View01();
        }

        private void load_Selection01()
        {

            Console.WriteLine($"{ShowMenu()}");
            data01[1] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[1], out data01[23]) == true)
            {
                if (Security_Serv01.string_only_digit(data01[1], out data01[24]) == true)
                {
                    int selection = int.Parse(data01[1].Trim());
                    int stringlength = menu_array01.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = menu_array01[selection].Trim();
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
        }
    }
}
