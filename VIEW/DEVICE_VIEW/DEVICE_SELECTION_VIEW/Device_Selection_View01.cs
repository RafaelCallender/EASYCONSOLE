using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.DEVICE_VIEW.DEVICE_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.DEVICES.DEVICE_HELPER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.DEVICE_VIEW.DEVICE_SELECTION_VIEW
{
    internal class Device_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Device_Helpers01 Device_H01 = new Device_Helpers01();
        private static string menu_string = $"device details 01\n" +
                   $"OS_String\n" +
                   $"load_device_details01\n" +
                   $"OS_details\n" +
                   $"Linux details\n" +
                   $"GetEnvironmentVariables_string\n" +
                   $"go back\n";
        private static string[] menu_array = menu_string.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Device_Selection_View01()
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


                case "device details 01":
                    _commands.Add(procedure, device_details_01);
                    break;
                case "OS_String":
                    _commands.Add(procedure, OS_String);
                    break;
                case "load_device_details01":
                    _commands.Add(procedure, load_device_details01);
                    break;
                case "OS_details":
                    _commands.Add(procedure, OS_details);
                    break;
                case "Linux details":
                    _commands.Add(procedure, Linux_details);
                    break;
                case "GetEnvironmentVariables_string":
                    _commands.Add(procedure, GetEnvironmentVariables_string);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
            }
        }
        private void device_details_01()
        {
            Console.WriteLine("needs work");
        }
        private void OS_String()
        {
            Console.WriteLine(Device_H01.OS_String);
        }
        private void load_device_details01()
        {
            Console.WriteLine(Device_H01.load_device_details01());
        }
        private void OS_details()
        {
            Console.WriteLine(Device_H01.OS_String);
        }
        private void Linux_details()
        {
            Console.WriteLine(Device_H01.GetLinuxDetails());
        }
        private void GetEnvironmentVariables_string()
        {
            Console.WriteLine(Device_H01.GetEnvironmentVariables_string);
        }
        private void go_back()
        {
            new Device_Main_View01();
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
        }
    }
}
