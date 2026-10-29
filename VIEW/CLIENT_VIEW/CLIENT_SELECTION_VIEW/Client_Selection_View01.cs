using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILE_SERVICES.FILE_PICKER;
using EASYPROJECT01.EASY_CALLENDER01.MODEL.CLIENT_MODEL;
using EASYPROJECT01.EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_SERVICES;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_CLIENTS_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.CLIENT_VIEW.CLIENT_SELECTION_VIEW
{
    internal class Client_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Sql_Client_Services01 Sql_Client_S01 = new Sql_Client_Services01();
        private static bool stored_procedure_bool = Sql_Client_S01.view_client_database_storedprocedures(out data01[50]);
        private static string stored_procedure_string = data01[50];
        private static string[] stored_procedure_array = stored_procedure_string.Split("\n");
        private static File_Picker01 File_P01 = new File_Picker01();
        private string types = string.Empty;
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Client_Selection_View01()
        {
            if (stored_procedure_bool == true)
            {
                load_Selection01();
            }
            else
            {
                Console.WriteLine(stored_procedure_string);
            }
        }

        private void load_Selection_data01()
        {

            string procedure = stored_procedure_array[int.Parse(data01[1])].Trim();
            switch (procedure)
            {
                case "delete_client_using_name":
                    _commands.Add(procedure, delete_client_using_name);
                    break;
                case "delete_client_using_phonenumber":
                    _commands.Add(procedure, delete_client_using_phonenumber);
                    break;
                case "find_client_api_key_by_emailaddress":
                    _commands.
                    Add(procedure, find_client_api_key_by_emailaddress);
                    break;
                case "find_client_api_key_by_name":
                    _commands.Add(procedure, find_client_api_key_by_name);
                    break;
                case "find_client_api_key_by_phonnumeber":
                    _commands.Add(procedure, find_client_api_key_by_phonnumeber);
                    break;
                case "find_client_apikey_by_apikey":
                    _commands.Add(procedure, find_client_apikey_by_apikey);
                    break;
                case "find_client_apikey_by_cashappdata01":
                    _commands.Add(procedure, find_client_apikey_by_cashappdata01);
                    break;
                case "find_client_apikey_by_venmoappdata01":
                    _commands.Add(procedure, find_client_apikey_by_venmoappdata01);
                    break;
                case "find_client_cashappdata01_by_apikey":
                    _commands.Add(procedure, find_client_cashappdata01_by_apikey);
                    break;
                case "find_client_cashappdata01_by_cashappdata01":
                    _commands.Add(procedure, find_client_cashappdata01_by_cashappdata01);
                    break;
                case "find_client_cashappdata01_by_emailaddress":
                    _commands.Add(procedure, find_client_cashappdata01_by_emailaddress);
                    break;
                case "find_client_cashappdata01_by_name":
                    _commands.Add(procedure, find_client_cashappdata01_by_name);
                    break;
                case "find_client_cashappdata01_by_paypalappdata01":
                    _commands.Add(procedure, find_client_cashappdata01_by_paypalappdata01);
                    break;
                case "find_client_cashappdata01_by_phonnumeber":
                    _commands.Add(procedure, find_client_cashappdata01_by_phonnumeber);
                    break;
                case "find_client_cashappdata01_by_venmoappdata01":
                    _commands.Add(procedure, find_client_cashappdata01_by_venmoappdata01);
                    break;
                case "find_client_colors_using_emailaddress":
                    _commands.Add(procedure, find_client_colors_using_emailaddress);
                    break;
                case "find_client_colors_using_name":
                    _commands.Add(procedure, find_client_colors_using_name);
                    break;
                case "find_client_colors_using_phonenumber":
                    _commands.Add(procedure, find_client_colors_using_phonenumber);
                    break;
                case "find_client_data_using_email":
                    _commands.Add(procedure, find_client_data_using_email);
                    break;
                case "find_client_data_using_latitude_and_longitude":
                    _commands.Add(procedure, find_client_data_using_latitude_and_longitude);
                    break;
                case "find_client_data_using_logo":
                    _commands.Add(procedure, find_client_data_using_logo);
                    break;
                case "find_client_data_using_name":
                    _commands.Add(procedure, find_client_data_using_name);
                    break;
                case "find_client_data_using_number":
                    _commands.Add(procedure, find_client_data_using_number);
                    break;
                case "find_client_emailaddress_by_apikey":
                    _commands.Add(procedure, find_client_emailaddress_by_apikey);
                    break;
                case "find_client_emailaddress_by_cashappdata01":
                    _commands.Add(procedure, find_client_emailaddress_by_cashappdata01);
                    break;
                case "find_client_emailaddress_by_emailaddress":
                    _commands.Add(procedure, find_client_emailaddress_by_emailaddress);
                    break;
                case "find_client_emailaddress_by_name":
                    _commands.Add(procedure, find_client_emailaddress_by_name);
                    break;
                case "find_client_emailaddress_by_paypalappdata01":
                    _commands.Add(procedure, find_client_emailaddress_by_paypalappdata01);
                    break;
                case "find_client_emailaddress_by_phonnumeber":
                    _commands.Add(procedure, find_client_emailaddress_by_phonnumeber);
                    break;
                case "find_client_emailaddress_by_venmoappdata01":
                    _commands.Add(procedure, find_client_emailaddress_by_venmoappdata01);
                    break;
                case "find_client_location_using_emailaddress":
                    _commands.Add(procedure, find_client_location_using_emailaddress);
                    break;
                case "find_client_location_using_name":
                    _commands.Add(procedure, find_client_location_using_name);
                    break;
                case "find_client_location_using_phonenumber":
                    _commands.Add(procedure, find_client_location_using_phonenumber);
                    break;
                case "find_client_logo_by_emailaddress":
                    _commands.Add(procedure, find_client_logo_by_emailaddress);
                    break;
                case "find_client_logo_by_logo":
                    _commands.Add(procedure, find_client_logo_by_logo);
                    break;
                case "find_client_logo_by_name":
                    _commands.Add(procedure, find_client_logo_by_name);
                    break;
                case "find_client_logo_by_phonenumber":
                    _commands.Add(procedure, find_client_logo_by_phonenumber);
                    break;
                case "find_client_name_by_cashappdata01":
                    _commands.Add(procedure, find_client_name_by_cashappdata01);
                    break;
                case "find_client_name_by_emailaddress":
                    _commands.Add(procedure, find_client_name_by_emailaddress);
                    break;
                case "find_client_name_by_name":
                    _commands.Add(procedure, find_client_name_by_name);
                    break;
                case "find_client_name_by_paypalappdata01":
                    _commands.Add(procedure, find_client_name_by_paypalappdata01);
                    break;
                case "find_client_name_by_phonnumeber":
                    _commands.Add(procedure, find_client_name_by_phonnumeber);
                    break;
                case "find_client_name_by_venmoappdata01":
                    _commands.Add(procedure, find_client_name_by_venmoappdata01);
                    break;
                case "find_client_paypalappdata01_by_apikey":
                    _commands.Add(procedure, find_client_paypalappdata01_by_apikey);
                    break;
                case "find_client_paypalappdata01_by_cashappdata01":
                    _commands.Add(procedure, find_client_paypalappdata01_by_cashappdata01);
                    break;
                case "find_client_paypalappdata01_by_emailaddress":
                    _commands.Add(procedure, find_client_paypalappdata01_by_emailaddress);
                    break;
                case "find_client_paypalappdata01_by_name":
                    _commands.Add(procedure, find_client_paypalappdata01_by_name);
                    break;
                case "find_client_paypalappdata01_by_paypalappdata01":
                    _commands.Add(procedure, find_client_paypalappdata01_by_paypalappdata01);
                    break;
                case "find_client_paypalappdata01_by_phonnumeber":
                    _commands.Add(procedure, find_client_paypalappdata01_by_phonnumeber);
                    break;
                case "find_client_paypalappdata01_by_venmoappdata01":
                    _commands.Add(procedure, find_client_paypalappdata01_by_venmoappdata01);
                    break;
                case "find_client_phonenumber_by_apikey":
                    _commands.Add(procedure, find_client_phonenumber_by_apikey);
                    break;
                case "find_client_phonenumber_by_cashappdata01":
                    _commands.Add(procedure, find_client_phonenumber_by_cashappdata01);
                    break;
                case "find_client_phonenumber_by_emailaddress":
                    _commands.Add(procedure, find_client_phonenumber_by_emailaddress);
                    break;
                case "find_client_phonenumber_by_name":
                    _commands.Add(procedure, find_client_phonenumber_by_name);
                    break;
                case "find_client_phonenumber_by_paypalappdata01":
                    _commands.Add(procedure, find_client_phonenumber_by_paypalappdata01);
                    break;
                case "find_client_phonenumber_by_phonnumeber":
                    _commands.Add(procedure, find_client_phonenumber_by_phonnumeber);
                    break;
                case "find_client_phonenumber_by_venmoappdata01":
                    _commands.Add(procedure, find_client_phonenumber_by_venmoappdata01);
                    break;
                case "find_client_venmoappdata01_by_apikey":
                    _commands.Add(procedure, find_client_venmoappdata01_by_apikey);
                    break;
                case "find_client_venmoappdata01_by_cashappdata01":
                    _commands.Add(procedure, find_client_venmoappdata01_by_cashappdata01);
                    break;
                case "find_client_venmoappdata01_by_emailaddress":
                    _commands.Add(procedure, find_client_venmoappdata01_by_emailaddress);
                    break;
                case "find_client_venmoappdata01_by_name":
                    _commands.Add(procedure, find_client_venmoappdata01_by_name);
                    break;
                case "find_client_venmoappdata01_by_paypalappdata01":
                    _commands.Add(procedure, find_client_venmoappdata01_by_paypalappdata01);
                    break;
                case "find_client_venmoappdata01_by_phonnumeber":
                    _commands.Add(procedure, find_client_venmoappdata01_by_phonnumeber);
                    break;
                case "find_client_venmoappdata01_by_venmoappdata01":
                    _commands.Add(procedure, find_client_venmoappdata01_by_venmoappdata01);
                    break;
                case "find_client_zellaappdata01_by_apikey":
                    _commands.Add(procedure, find_client_zellaappdata01_by_apikey);
                    break;
                case "find_client_zellaappdata01_by_zellaappdata01":
                    _commands.Add(procedure, find_client_zellaappdata01_by_zellaappdata01);
                    break;
                case "find_client_zelleappdata01_by_cashappdata01":
                    _commands.Add(procedure, find_client_zelleappdata01_by_cashappdata01);
                    break;
                case "find_client_zelleappdata01_by_emailaddress":
                    _commands.Add(procedure, find_client_zelleappdata01_by_emailaddress);
                    break;
                case "find_client_zelleappdata01_by_name":
                    _commands.Add(procedure, find_client_zelleappdata01_by_name);
                    break;
                case "find_client_zelleappdata01_by_phonnumeber":
                    _commands.Add(procedure, find_client_zelleappdata01_by_phonnumeber);
                    break;
                case "find_client_zelleappdata01_by_venmoappdata01":
                    _commands.Add(procedure, find_client_zelleappdata01_by_venmoappdata01);
                    break;
                case "insert_client_data":
                    _commands.Add(procedure, insert_client_data);
                    break;
                case "update_clients_apikey_using_apikey":
                    _commands.Add(procedure, update_clients_apikey_using_apikey);
                    break;
                case "update_clients_cashappdata01_using_cashappdata01":
                    _commands.Add(procedure, update_clients_cashappdata01_using_cashappdata01);
                    break;
                case "update_clients_email_using_email":
                    _commands.Add(procedure, update_clients_email_using_email);
                    break;
                case "update_clients_logo_using_logo":
                    _commands.Add(procedure, update_clients_logo_using_logo);
                    break;
                case "update_clients_name_using_name":
                    _commands.Add(procedure, update_clients_name_using_name);
                    break;
                case "update_clients_paypalappdata01_using_paypalappdata01":
                    _commands.Add(procedure, update_clients_paypalappdata01_using_paypalappdata01);
                    break;
                case "update_clients_phnenumber_using_phonenumbe":
                    _commands.Add(procedure, update_clients_phnenumber_using_phonenumber);
                    break;
                case "update_clients_venmoappdata01_using_venmoappdata01":
                    _commands.Add(procedure, update_clients_venmoappdata01_using_venmoappdata01);
                    break;
                case "update_clients_zelleappdata01_using_zellappdata01":
                    _commands.Add(procedure, update_clients_zelleappdata01_using_zellappdata01);
                    break;
                case "view_all_client_data":
                    _commands.Add(procedure, view_all_client_data);
                    break;

            }

        }

        private string load_Client_Selection_View02_String()
        {
            string res = string.Empty;
            for (int i = 0; i < Client_Model01.client_type.Length; i++)
            {
                res += $"{i}.) {Client_Model01.client_type[i]}\n";
            }
            return $"{res}\n";
        }



        private void delete_client_using_name()
        {
            Console.Write("Name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.delete_client_using_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void delete_client_using_phonenumber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.delete_client_using_phonenumber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_api_key_by_emailaddress()
        {
            Console.Write("email ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_api_key_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_api_key_by_name()
        {
            Console.Write("name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_api_key_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_api_key_by_phonnumeber()
        {
            Console.Write("phonenumber ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[23]) == true)
                {
                    if (Sql_Client_S01.find_client_api_key_by_phonnumeber(data01[5], out data01[24]) == true)
                    {
                        Console.WriteLine(data01[24]);
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
            else
            {
                Console.WriteLine(data01[23]);
            }

        }

        private void find_client_apikey_by_apikey()
        {
            Console.Write("api key");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_apikey_by_apikey(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_apikey_by_cashappdata01()
        {
            Console.Write("cashapp");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_apikey_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_apikey_by_paypalappdata01()
        {
            Console.Write("paypal");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_apikey_by_paypalappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_apikey_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_apikey_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_cashappdata01_by_apikey()
        {
            Console.Write("apikey ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_cashappdata01_by_apikey(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_cashappdata01_by_cashappdata01()
        {
            Console.Write("cashapp");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_cashappdata01_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_cashappdata01_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_cashappdata01_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_cashappdata01_by_name()
        {
            Console.Write("name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_cashappdata01_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_cashappdata01_by_paypalappdata01()
        {
            Console.Write("paypal");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_cashappdata01_by_paypalappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_cashappdata01_by_phonnumeber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Client_S01.find_client_cashappdata01_by_phonnumeber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_cashappdata01_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_cashappdata01_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_colors_using_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_colors_using_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_colors_using_name()
        {
            Console.Write("name");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_colors_using_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_colors_using_phonenumber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[23]) == true)
                {
                    if (Sql_Client_S01.find_client_colors_using_phonenumber(data01[5], out data01[24]) == true)
                    {
                        Console.WriteLine(data01[24]);
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
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void find_client_data_using_email()
        {
            Console.Write("email: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_data_using_email(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_data_using_latitude_and_longitude()
        {
            Console.Write("user latitude ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {

                Console.Write("user longitude ");
                data01[5] = Console.ReadLine() ?? "";
                if (Security_Serv01.empty_string(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_data_using_latitude_and_longitude(data01[5], data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void find_client_data_using_logo()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_data_using_logo(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_data_using_name()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_data_using_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_data_using_number()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_data_using_number(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_emailaddress_by_apikey()
        {
            Console.Write("api key ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_emailaddress_by_apikey(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_emailaddress_by_cashappdata01()
        {
            Console.Write("cashapp: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_emailaddress_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_emailaddress_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_emailaddress_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[24]);
                    }
                    else
                    {
                        Console.WriteLine(data01[24]);
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

        private void find_client_emailaddress_by_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.empty_string(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_emailaddress_by_name(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_emailaddress_by_paypalappdata01()
        {
            Console.Write("paypal ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_emailaddress_by_paypalappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_emailaddress_by_phonnumeber()
        {
            Console.Write("phonenumber");

            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_emailaddress_by_phonnumeber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_emailaddress_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_emailaddress_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_location_using_emailaddress()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_location_using_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_location_using_name()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_location_using_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_location_using_phonenumber()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_location_using_phonenumber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_logo_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_logo_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_logo_by_logo()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_logo_by_logo(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_logo_by_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_logo_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_logo_by_phonenumber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[23]) == true)
                {
                    if (Sql_Client_S01.find_client_logo_by_phonenumber(data01[5], out data01[24]) == true)
                    {
                        Console.WriteLine(data01[24]);
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
            else
            {
                Console.WriteLine(data01[23]);
            }
        }
        private void find_client_name_by_cashappdata01()
        {
            Console.Write("cashapp: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_name_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_name_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_name_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_name_by_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_name_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_name_by_paypalappdata01()
        {
            Console.Write("paypal ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_name_by_paypalappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_name_by_phonnumeber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_name_by_phonnumeber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_name_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_name_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_paypalappdata01_by_apikey()
        {
            Console.Write("api key ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_paypalappdata01_by_apikey(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_paypalappdata01_by_cashappdata01()
        {
            Console.Write("cashapp: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_paypalappdata01_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_paypalappdata01_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_paypalappdata01_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_paypalappdata01_by_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_paypalappdata01_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_paypalappdata01_by_paypalappdata01()
        {
            Console.Write("paypal ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_paypalappdata01_by_paypalappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_paypalappdata01_by_phonnumeber()
        {
            Console.Write("phonenumber");

            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_paypalappdata01_by_phonnumeber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_paypalappdata01_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_paypalappdata01_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_phonenumber_by_apikey()
        {
            Console.Write("api key ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_phonenumber_by_apikey(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_phonenumber_by_cashappdata01()
        {
            Console.Write("cashapp: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_phonenumber_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_phonenumber_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_phonenumber_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_phonenumber_by_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_phonenumber_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_phonenumber_by_paypalappdata01()
        {
            Console.Write("paypal");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_phonenumber_by_paypalappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_phonenumber_by_phonnumeber()
        {
            Console.Write("phonenumber");

            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Client_S01.find_client_phonenumber_by_phonnumeber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_phonenumber_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_phonenumber_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_venmoappdata01_by_apikey()
        {
            Console.Write("api key ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_venmoappdata01_by_apikey(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_venmoappdata01_by_cashappdata01()
        {
            Console.Write("cashapp: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_venmoappdata01_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_venmoappdata01_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_venmoappdata01_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_venmoappdata01_by_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_venmoappdata01_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_venmoappdata01_by_paypalappdata01()
        {
            Console.Write("paypal ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_venmoappdata01_by_paypalappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_venmoappdata01_by_phonnumeber()
        {
            Console.Write("phonenumber");

            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_venmoappdata01_by_phonnumeber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_venmoappdata01_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_venmoappdata01_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_zellaappdata01_by_apikey()
        {
            Console.Write("api key ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_zellaappdata01_by_apikey(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_zellaappdata01_by_zellaappdata01()
        {
            Console.Write("Client Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_zellaappdata01_by_zellaappdata01(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_zelleappdata01_by_cashappdata01()
        {
            Console.Write("cashapp: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_zelleappdata01_by_cashappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_zelleappdata01_by_emailaddress()
        {
            Console.Write("email");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.email_check(data01[5], out data01[24]) == true)
                {

                    if (Sql_Client_S01.find_client_zelleappdata01_by_emailaddress(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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


        private void find_client_zelleappdata01_by_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_zelleappdata01_by_name(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void find_client_zelleappdata01_by_phonnumeber()
        {
            Console.Write("phonenumber");

            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.phone_check(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.find_client_zelleappdata01_by_phonnumeber(data01[5], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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

        private void find_client_zelleappdata01_by_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                if (Sql_Client_S01.find_client_zelleappdata01_by_venmoappdata01(data01[5], out data01[24]) == true)
                {
                    Console.WriteLine(data01[24]);
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

        private void insert_client_data()
        {

            Console.WriteLine($"client_name");
            data01[5] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[5], out data01[30]) == true)
            {
                Console.WriteLine($"client_emailaddress");
                data01[6] = Console.ReadLine() ?? string.Empty;
                if (Security_Serv01.empty_string(data01[6], out data01[31]) == true)
                {
                    if (Security_Serv01.email_check(data01[6], out data01[32]) == true)
                    {
                        Console.WriteLine($"client phonenumber");
                        data01[7] = Console.ReadLine() ?? string.Empty;
                        if (Security_Serv01.empty_string(data01[7], out data01[33]) == true)
                        {
                            if (Security_Serv01.phone_check(data01[7], out data01[34]) == true)
                            {
                                Console.WriteLine($"client_api_key");
                                data01[8] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[8], out data01[35]) == true)
                                {
                                    Console.WriteLine($"client_cashappdata01");
                                    data01[9] = Console.ReadLine() ?? string.Empty;
                                    if (Security_Serv01.empty_string(data01[9], out data01[36]) == true)
                                    {

                                        Console.WriteLine($"client_zelleappdata01");
                                        data01[10] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[11], out data01[37]) == true)
                                        {
                                            Console.WriteLine($"client_venmoappdata01");
                                            data01[12] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[12], out data01[38]) == true)
                                            {
                                                Console.WriteLine($"client_paypalappdata01");
                                                data01[13] = Console.ReadLine() ?? string.Empty;
                                                if (Security_Serv01.empty_string(data01[13], out data01[39]) == true)
                                                {

                                                    Console.WriteLine($"client_logo");
                                                    if (File_P01.FilePickerLinux02(data01[13], out data01[40]) == true)
                                                    {

                                                        Console.WriteLine($"client_primary_color");
                                                        data01[14] = Console.ReadLine() ?? string.Empty;
                                                        if (Security_Serv01.empty_string(data01[14], out data01[41]) == true)
                                                        {
                                                            Console.WriteLine($"client_secondary_color");
                                                            data01[15] = Console.ReadLine() ?? string.Empty;
                                                            if (Security_Serv01.empty_string(data01[15], out data01[42]) == true)
                                                            {
                                                                Console.WriteLine($"client_tertiary_color");
                                                                data01[14] = Console.ReadLine() ?? string.Empty;
                                                                if (Security_Serv01.empty_string(data01[14], out data01[43]) == true)
                                                                {
                                                                    Console.WriteLine($"client_tertiary_color");
                                                                    data01[15] = Console.ReadLine() ?? string.Empty;
                                                                    if (Security_Serv01.empty_string(data01[15], out data01[44]) == true)
                                                                    {
                                                                        Console.WriteLine($"client_social_media");
                                                                        data01[16] = Console.ReadLine() ?? string.Empty;
                                                                        if (Security_Serv01.empty_string(data01[16], out data01[45]) == true)
                                                                        {
                                                                            Console.WriteLine($"client_type");
                                                                            Console.WriteLine(load_Client_Selection_View02_String());

                                                                            data01[17] = Console.ReadLine() ?? string.Empty;
                                                                            if (Security_Serv01.empty_string(data01[17], out data01[46]) == true)
                                                                            {
                                                                                if (Security_Serv01.string_only_digit(data01[17], out data01[47]) == true)

                                                                                    types = Client_Model01.client_type[int.Parse(data01[17].Trim())];

                                                                                if (Sql_Client_S01.insert_client_data(data01[5], data01[6], data01[7], data01[8], data01[9],
                                                                                                                       data01[10], data01[11], data01[12], data01[13], data01[14],
                                                                                                                       data01[15], data01[16], data01[17], types,
                                                                                                                        out data01[47]) == true)
                                                                                {
                                                                                    Console.WriteLine(data01[47]);
                                                                                    Console.WriteLine(load_Client_Selection_View02_String());
                                                                                    data01[1] = Console.ReadLine() ?? string.Empty;


                                                                                }
                                                                                else
                                                                                {
                                                                                    Console.WriteLine(data01[25]);
                                                                                    data01[5] = Console.ReadLine() ?? string.Empty;

                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine(data01[23]);
                                                                                data01[5] = Console.ReadLine() ?? string.Empty;

                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine(data01[23]);
                                                                            data01[5] = Console.ReadLine() ?? string.Empty;

                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine(data01[45]);
                                                                        data01[17] = Console.ReadLine() ?? string.Empty;

                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine(data01[44]);
                                                                    data01[15] = Console.ReadLine() ?? string.Empty;

                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine(data01[43]);
                                                                data01[14] = Console.ReadLine() ?? string.Empty;

                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine(data01[42]);
                                                            data01[13] = Console.ReadLine() ?? string.Empty;

                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(data01[41]);
                                                        data01[12] = Console.ReadLine() ?? string.Empty;

                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[40]);
                                                    data01[11] = Console.ReadLine() ?? string.Empty;

                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[39]);
                                                data01[10] = Console.ReadLine() ?? string.Empty;

                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[38]);
                                            data01[9] = Console.ReadLine() ?? string.Empty;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[37]);
                                        data01[8] = Console.ReadLine() ?? string.Empty;

                                    }
                                }
                                else
                                {
                                    Console.WriteLine(data01[36]);
                                    data01[7] = Console.ReadLine() ?? string.Empty;

                                }
                            }
                            else
                            {
                                Console.WriteLine(data01[35]);
                                data01[6] = Console.ReadLine() ?? string.Empty;

                            }
                        }
                        else
                        {
                            Console.WriteLine(data01[34]);
                            data01[5] = Console.ReadLine() ?? string.Empty;

                        }
                    }
                    else
                    {
                        Console.WriteLine(data01[33]);
                        data01[5] = Console.ReadLine() ?? string.Empty;

                    }
                }
                else
                {
                    Console.WriteLine(data01[32]);
                    data01[5] = Console.ReadLine() ?? string.Empty;

                }
            }
            else
            {
                Console.WriteLine(data01[31]);
                data01[5] = Console.ReadLine() ?? string.Empty;

            }
        }
        private void update_clients_apikey_using_apikey()
        {
            Console.Write("api key");
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("new api key");
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_cashappdata01_using_cashappdata01(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void update_clients_cashappdata01_using_cashappdata01()
        {
            Console.Write("cashapp");
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("new cashapp");
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_cashappdata01_using_cashappdata01(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void update_clients_email_using_email()
        {
            Console.Write("email");
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("new email");
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_email_using_email(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void update_clients_logo_using_logo()
        {
            Console.Write("update your logo");
            data01[5] = Console.ReadLine() ?? "";
            if (File_P01.FilePickerLinux02(data01[5], out data01[23]) == true)
            {
                if (Security_Serv01.empty_string(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_logo_using_logo(data01[5], data01[6], out data01[24]) == true)
                    {
                        Console.WriteLine(data01[24]);
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
        private void update_clients_name_using_name()
        {
            Console.Write("Name: ");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("New Name: ");
                data01[6] = Console.ReadLine() ?? "";
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_name_using_name(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void update_clients_paypalappdata01_using_paypalappdata01()
        {
            Console.Write("paypal");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("new paypal");
                data01[6] = Console.ReadLine() ?? "";
                if (Security_Serv01.empty_string(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_paypalappdata01_using_paypalappdata01(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void update_clients_phnenumber_using_phonenumber()
        {
            Console.Write("phonenumber");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("new phonenumber");
                data01[5] = Console.ReadLine() ?? "";
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_phnenumber_using_phonenumber(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void update_clients_venmoappdata01_using_venmoappdata01()
        {
            Console.Write("venmo");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("new venmo");
                data01[5] = Console.ReadLine() ?? "";
                if (Security_Serv01.empty_string(data01[6], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_venmoappdata01_using_venmoappdata01(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void update_clients_zelleappdata01_using_zellappdata01()
        {
            Console.Write("zell");
            data01[5] = Console.ReadLine() ?? "";
            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
            {
                Console.Write("new zell");
                data01[6] = Console.ReadLine() ?? "";
                if (Security_Serv01.empty_string(data01[5], out data01[24]) == true)
                {
                    if (Sql_Client_S01.update_clients_zelleappdata01_using_zellappdata01(data01[5], data01[6], out data01[25]) == true)
                    {
                        Console.WriteLine(data01[25]);
                    }
                    else
                    {
                        Console.WriteLine(data01[25]);
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
        private void view_all_client_data()
        {
            if (Sql_Client_S01.view_all_client_data(out data01[24]) == true)
            {
                Console.WriteLine(data01[24]);
            }
            else
            {
                Console.WriteLine(data01[24]);
            }
        }

        private string ShowMenu()
        {
            if (stored_procedure_bool == true)
            {
                for (int i = 0; i < stored_procedure_array.Length; i++)
                {
                    data01[20] += $"{i}.) {stored_procedure_array[i]}\n";
                }
                return data01[20];
            }
            else
            {
                return stored_procedure_string;
            }

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
                    int stringlength = stored_procedure_array.Length;
                    if (selection >= 0 &&
                        selection < stringlength)
                    {
                        string key = stored_procedure_array[selection].Trim();
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
