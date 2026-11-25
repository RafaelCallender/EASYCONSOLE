using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.UPLOAD_VIEW.UPLOAD_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SQL.SQL_SERVICES.SQL_UPLOAD_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.UPLOAD_VIEW.UPLOAD_SELECTION_VIEW
{
    internal class Upload_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_S01 = new Security_Services01();
        private static Sql_Upload_Services01 MySql_Upload_S01 = new Sql_Upload_Services01();
        private bool stored_proccedure_bool = MySql_Upload_S01.view_database_storedprocedures(out data01[50]);
        public string stored_proccedure_string = data01[50];

            public Upload_Selection_View02()
        {
            load_Upload_View01();
        }
        private string load_Upload_Selection_View02_string()
        {
            string[] res = stored_proccedure_string.Split("\n");
            for (int i = 0; i < res.Length; i++)
            {
                data01[80] += $"{i}.){res[i]}\n";

            }
            return data01[80];
        }
        private void load_Upload_View01()
        {
            Console.WriteLine(load_Upload_Selection_View02_string());
            data01[1] = Console.ReadLine() ?? string.Empty;
            while (true)
            {
                if (Security_S01.empty_string(data01[1], out data01[23]) == true)
                {
                    if (Security_S01.string_only_digit(data01[1], out data01[24]) == true)
                    {
                        switch (int.Parse(data01[1]))
                        {
                            case 1:

                                Console.WriteLine("Username\n");
                                data01[2] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[2], out data01[25]) == true)
                                {
                                    Console.WriteLine("OriginalName\n");
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    if (Security_S01.empty_string(data01[3], out data01[25]) == true)
                                    {

                                        Console.WriteLine("StoredName\n");
                                        data01[4] = Console.ReadLine() ?? string.Empty;
                                        if (Security_S01.empty_string(data01[4], out data01[25]) == true)
                                        {

                                            Console.WriteLine("FilePath\n");
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            if (Security_S01.empty_string(data01[5], out data01[25]) == true)
                                            {
                                                Console.WriteLine("ContentType\n");
                                                data01[5] = Console.ReadLine() ?? string.Empty;
                                                if (Security_S01.empty_string(data01[5], out data01[25]) == true)
                                                {

                                                    Console.WriteLine("FileSize\n");
                                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                                    if (Security_S01.empty_string(data01[5], out data01[30]) == true)
                                                    {
                                                        Console.WriteLine("UploadDate\n");
                                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                                        if (Security_S01.empty_string(data01[5], out data01[30]) == true)
                                                        {


                                                            if (MySql_Upload_S01.insert_data(data01[2], data01[3], data01[4], data01[5], data01[6], data01[7],data01[8], out data01[25]) == true)
                                                            {



                                                                Console.WriteLine(

                                                                    $"{data01[25]}\n"



                                                                );

                                                                Console.WriteLine(load_Upload_Selection_View02_string());
                                                                data01[1] = Console.ReadLine() ?? string.Empty;
                                                                break;

                                                            }
                                                            else
                                                            {



                                                                Console.WriteLine(data01[25]);
                                                                data01[8] = Console.ReadLine() ?? string.Empty;
                                                                continue;
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine(data01[31]);
                                                            data01[8] = Console.ReadLine() ?? string.Empty;
                                                            continue;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(data01[30]);
                                                        data01[8] = Console.ReadLine() ?? string.Empty;
                                                        continue;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[25]);
                                                    data01[6] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[25]);
                                                data01[5] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[25]);
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[25]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(data01[25]);
                                    data01[8] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 2:

                                Console.WriteLine("Username\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_S01.empty_string(data01[3], out data01[23]) == true)
                                {

                                    if (MySql_Upload_S01.find_username_using_username(data01[3], out data01[25]) == true)
                                    {


                                        Console.WriteLine(data01[25]);
                                        Console.WriteLine(load_Upload_Selection_View02_string());
                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[25]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;

                                    }


                                }
                                else
                                {

                                    Console.WriteLine(data01[24]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                            default:
                                Console.WriteLine(load_Upload_Selection_View02_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine(data01[23]);
                        data01[3] = Console.ReadLine() ?? string.Empty;
                        continue;
                    }
                }
            }
        }
    }
}



