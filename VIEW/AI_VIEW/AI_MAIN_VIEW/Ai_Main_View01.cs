using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_SELECTION_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.AI_VIEW.AI_MAIN_VIEW
{
    internal class Ai_Main_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static string menu_string = $"Hair changer\n" +
                                            "text to text generation\n" +
                                            "anime face changer\n" +
                                            "image generation\n" +
                                             "back\n";

        private static string[] menu_array = menu_string.Split("\n");

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
  
        public Ai_Main_View01()
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
            switch (menu_array[int.Parse(data01[1])])
            {
               
                case "Hair changer":
                    _commands.Add(procedure, Hair_changer);
                    break;
                case "text to text generation":
                    _commands.Add(procedure, text_to_text_generation);
                    break;
                case "anime face changer":
                    _commands.Add(procedure, anime_face_changer);
                    break;
                case "image generation":
                    _commands.Add(procedure, image_generation);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;
            }
        }
        private void Hair_changer()
        {
            new Ai_Selection_View01();
        }
        private void text_to_text_generation()
        {
            new Ai_Selection_View02();
        }
        private void anime_face_changer()
        {
            new Ai_Selection_View03();
        }
        private void image_generation()
        {
            new Ai_Selection_View04();
        }
        private void back()
        {
            Program.load_main();
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
