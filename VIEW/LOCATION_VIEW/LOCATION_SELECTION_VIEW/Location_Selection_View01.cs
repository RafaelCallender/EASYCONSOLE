using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.DEVICE_SERVICES;
using EASYCONSOLE.VIEW.LOCATION_VIEW.LOCATION_MAIN_VIEW;
using EASY_CALLENDER01.SERVICES.DEVICE_SERVICES;
using EASY_CALLENDER01.SERVICES.LOCATION.LOCATION_HELPER;
namespace EASYCONSOLE.VIEW.LOCATION_VIEW.LOCATION_SELECTION_VIEW
{
    internal class Location_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Device_Services01 Device_S01 = new Device_Services01();
        private static Location_Helper01 Location_H01 = new Location_Helper01();
        public Location_Selection_View01()
        {
            load_Location_Selection_View01().Wait();
        }
        private string load_Location_Selection_View01_string()
        {
            return $"1.)get device full location\n" +
                   $"2.)get ip address\n" +
                   $"3.)get city\n" +
                   $"4.)get state\n" +
                   $"5.)get country\n" +
                   $"6.)get location grid\n" +
                   $"7.)get_longitude\n" +
                   $"8.)get_latitude\n" +
                   $"9.) go back";
        }

        private async Task load_Location_Selection_View01()
        {


            Console.WriteLine(load_Location_Selection_View01_string());
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
                                Console.WriteLine(await Device_S01.get_device_ip());
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:
                                Console.WriteLine(Location_Helper01.get_ipaddress01);
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 3:
                                Console.WriteLine(Location_Helper01.get_city01);
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 4:
                                Console.WriteLine(Location_Helper01.get_state01);
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 5:
                                Console.WriteLine(Location_Helper01.get_country01);
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 6:
                                Console.WriteLine(Location_Helper01.get_location_grid01);
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 7:
                                Console.WriteLine(Location_Helper01.get_longitude);
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 8:
                                Console.WriteLine(Location_Helper01.get_latitude);
                                Console.WriteLine(load_Location_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 9:
                                new Location_Main_View01();
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