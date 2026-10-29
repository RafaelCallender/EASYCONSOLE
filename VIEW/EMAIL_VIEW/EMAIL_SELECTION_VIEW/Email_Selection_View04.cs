using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.EMAIL_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_MAIN_VIEW;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.EMAIL_VIEW.EMAIL_SELECTION_VIEW
{
    internal class Email_Selection_View04
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Email_Services01 Email_S01 = new Email_Services01();
        private static DateTime dt = DateTime.Now;
        private static string dtstring = dt.ToString("yyyy-dd-MM");

        private static string menu_string = $"send email\n" +
                                                $"back\n";

        private static string[] menu_array = menu_string.Split("\n");

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);


        public Email_Selection_View04()
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
                    case "send email":
                        _commands.Add(procedure, send_email);
                        break;
                    case "go back":
                        _commands.Add(procedure, go_back);
                        break;
                }
            
        }
        private async void send_email()
        {

            Console.WriteLine("full name\n");
            data01[2] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[2], out data01[25]) == true)
            {



                Console.WriteLine("Email Addresss\n");
                data01[3] = Console.ReadLine() ?? string.Empty;
                if (Security_Serv01.empty_string(data01[3], out data01[27]) == true)
                {
                    if (Security_Serv01.email_check(data01[3], out data01[26]) == true)
                    {



                        Console.WriteLine("Phonenumber\n");
                        data01[4] = Console.ReadLine() ?? string.Empty;
                        if (Security_Serv01.empty_string(data01[4], out data01[28]) == true)
                        {
                            if (Security_Serv01.phone_check(data01[4], out data01[29]) == true)
                            {



                                Console.WriteLine("Message\n");
                                data01[5] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[5], out data01[30]) == true)
                                {
                                    var res = await Security_Serv01.is_connected_to_netwrok_linux();
                                    if (res.success == true)
                                    {
                                        if (Email_S01.send_email(data01[2], data01[3], data01[4], data01[5], out data01[31]) == true)
                                        {

                                            Console.WriteLine(

                                                $"{data01[31]}\n"

                                            );


                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[31]);

                                        }
                                    }
                                    else
                                    {
                                          Console.WriteLine(res.output);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(data01[30]);

                                }
                            }
                            else
                            {
                                Console.WriteLine(data01[28]);

                            }
                        }
                        else
                        {
                            Console.WriteLine(data01[26]);

                        }
                    }
                    else
                    {
                        Console.WriteLine(data01[27]);

                    }
                }
                else
                {
                    Console.WriteLine(data01[25]);

                }
            }
        }
        private void go_back()
        {
            new Email_Main_View01();
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
