using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using System;
using System.Collections.Generic;
using System.Text;
using EASYPROJECT01.EASYCONSOLE.VIEW.STUIDO_VIEW.STUDIO_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.AUDIO_SERVICES;
namespace EASYPROJECT01.EASYCONSOLE.VIEW.STUIDO_VIEW.STUIDIO_SELECTION_VIEW
{
    internal class Studio_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"andriod_sound_options\n" +
                                             $"go back";
        private static string[] menu_array = menu_string.Split("\n");
        private static Audio_Services01 Audio_Serv01 = new Audio_Services01();
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);

        public Studio_Selection_View01()
        {
            load_Selection01();
        }
        private string ShowMenu()
        {
            for (int i = 0; i < menu_array.Length; i++)
            {
                data01[20] += $"{i}.) {menu_array[i]}\n";
            }
            return data01[20];
        }
        private void load_Selection_data01()
        {
            string procedure = menu_array[int.Parse(data01[1])].Trim();
            switch (procedure)
            {

                case "andriod_sound_options":
                    _commands.Add(procedure, andriod_sound_options);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;
            }
        }
        private void andriod_sound_options()
        {
            Console.WriteLine("only for andriod");
        }
        private void go_back()
        {
            new Studio_Main_View01();
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
