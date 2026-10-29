using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.LOCATION_VIEW.LOCATION_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LOCATION_VIEW.LOCATION_SELECTION_VIEW
{
    internal class Location_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Location_Services03 Location_Serv03 = new Location_Services03();
        private static string menu_string01 = $"{Location_Manager01.raw_data}\n" +
                     $"get device full location\n" +
                      $"get ip address\n" +
                      $"get city\n" +
                      $"get state\n" +
                      $"get country\n" +
                      $"get location grid\n" +
                      $"get longitude\n" +
                      $"get latitude\n" +
                      "GetLocationDataAsync\n" +
                      "GetLocationDataAsync01\n" +
                             "GetCoordinates\n" +
                      $"go back";

        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        private static Location_Services01 Location_Serv01 = new Location_Services01();
        private static Location_Services02 Location_Serv02 = new Location_Services02();
        public Location_Selection_View01()
        {
            load_Selection01();
        }
        private async void Location_Manager01_raw_data()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_ipaddress01);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_device_full_location()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_ipaddress01);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_ip_address()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_ipaddress01);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_city()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_city01);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_state()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_state01);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_country()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_country01);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_location_grid()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_location_grid01);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_longitude()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_longitude);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private async void get_latitude()
        {
            var res = await Security_Serv01.is_connected_to_netwrok_linux();
            if (res.success == true)
            {
                Console.WriteLine(Location_Manager01.get_latitude);
            }
            else
            {
                Console.WriteLine(res.output);
            }
        }
        private void go_back()
        {
            new Location_Main_View01();
        }
        private async void GetCoordinates()
        {
            Console.WriteLine("address");
            data01[2] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {
                Console.WriteLine(await Location_Serv03.GetCoordinates(data01[2].Trim()));
            }
            else
            {
                Console.WriteLine(data01[23]);
            }

        }
        private async void GetLocationDataAsync01()
        {
            Console.WriteLine("address\n");
            data01[1] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine(await Location_Serv01.GetLocationDataAsync01(data01[1]));
            }

            else
            {
                Console.WriteLine(data01[23]);
            }
        }
        private async void GetLocationDataAsync()
        {
            Console.WriteLine("address\n");
            data01[1] = Console.ReadLine();
            if (Security_Serv01.empty_string(data01[2], out data01[23]) == true)
            {

                Console.WriteLine(await Location_Serv01.GetLocationDataAsync01(data01[1]));
            }

            else
            {
                Console.WriteLine(data01[23]);
            }
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1])].Trim();
            switch (procedure)
            {
                case "raw data":
                    _commands.Add(procedure, Location_Manager01_raw_data);
                    break;
                case "get device full location":
                    _commands.Add(procedure, get_device_full_location);
                    break;
                case "get ip address":
                    _commands.Add(procedure, get_ip_address);
                    break;
                case "get city":
                    _commands.Add(procedure, get_city);
                    break;
                case "get state":
                    _commands.Add(procedure, get_state);
                    break;
                case "get country":
                    _commands.Add(procedure, get_country);
                    break;
                case "get location grid":
                    _commands.Add(procedure, get_location_grid);
                    break;
                case "get longitude":
                    _commands.Add(procedure, get_longitude);
                    break;
                case "get latitude":
                    _commands.Add(procedure, get_latitude);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
                case "GetLocationDataAsync":
                    _commands.Add(procedure, GetLocationDataAsync);
                    break;
                case "GetLocationDataAsync01":
                    _commands.Add(procedure, GetLocationDataAsync01);
                    break;
                case "GetCoordinates":
                    _commands.Add(procedure, GetCoordinates);
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
