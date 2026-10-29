using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.LINUX_VIEW.LINUX_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.LINUX.LINUX_SERVICES;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.LINUX_VIEW.LINUX_SELECTION_VIEW
{
    internal class Linux_Selection_View02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Linux_Services02 Linux_S02 = new Linux_Services02();
        private static string menu_string01 = $"github upload all projects\n" +
                    $"github upload EASYWEBB\n" +
                    $"github upload EASYCONSOLE\n" +
                    $"github upload EASY_MOBILE\n" +
                    $"github upload EASY_CALLENDER01\n" +
                    $"create repository\n" +
                    $"choose repository\n" +
                    $"delete repository\n" +
                    $"go back\n";
        private static string[] menu_array01 = menu_string01.Split("\n");
        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Linux_Selection_View02()
        {
            load_Selection01();
        }
        private void load_Selection_data01()
        {

            string procedure = menu_array01[int.Parse(data01[1].Trim())].Trim();
            switch (procedure)
            {
                case "github upload all projects":
                    _commands.Add(procedure, github_upload_all_projects);
                    break;
                case "github upload EASYWEBB":
                    _commands.Add(procedure, github_upload_EASYWEBB);
                    break;
                case "github upload EASYCONSOLE":
                    _commands.Add(procedure, github_upload_EASYCONSOLE);
                    break;
                case "github upload EASY_MOBILE":
                    _commands.Add(procedure, github_upload_EASY_MOBILE);
                    break;
                case "github upload EASY_CALLENDER01":
                    _commands.Add(procedure, github_upload_EASY_CALLENDER01);
                    break;
                case "create repository":
                    _commands.Add(procedure, create_repository);
                    break;
                case "choose repository":
                    _commands.Add(procedure, choose_repository);
                    break;
                case "delete repository":
                    _commands.Add(procedure, delete_repository);
                    break;
                case "go back":
                    _commands.Add(procedure, go_back);
                    break;

            }
        }

        private void github_upload_all_projects()
        {
            Console.WriteLine(Linux_S02.github_upload_all_projects());

        }

        private void github_upload_EASYWEBB()
        {
            Console.WriteLine(Linux_S02.github_upload_EASYWEBB());
        }

        private void github_upload_EASYCONSOLE()
        {

            Console.WriteLine(Linux_S02.github_upload_EASYCONSOLE());
        }

        private void github_upload_EASY_MOBILE()
        {
            Console.WriteLine(Linux_S02.github_upload_EASY_MOBILE());

        }

        private void github_upload_EASY_CALLENDER01()
        {

            Console.WriteLine(Linux_S02.github_upload_EASY_CALLENDER01());
        }

        private void create_repository()
        {
            Console.WriteLine("name your repository");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {


                Console.WriteLine(Linux_S02.github_create_repository(data01[3]));

            }
            else
            {
                Console.WriteLine(data01[23]);

            }

        }

        private void choose_repository()
        {
            Console.WriteLine("github username");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                Console.WriteLine($"choose your repository\n");
                Console.WriteLine($"{Linux_S02.github_list_repository(data01[3])}");
            }
            else
            {
                Console.WriteLine(data01[23]);
            }

        }

        private void delete_repository()
        {
            Console.WriteLine("delete your repository");
            data01[3] = Console.ReadLine() ?? string.Empty;
            if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
            {
                Console.WriteLine(Linux_S02.github_delete_repository(data01[3]));
            }
            else
            {
                Console.WriteLine(data01[23]);
            }
        }

        private void go_back()
        {
            new Linux_Main_View01();
        }
        private string ShowMenu()
        {
            data01[20] = string.Empty;
            for (int i = 0; i < menu_array01.Length; i++)
            {
                data01[20] += $"{i}.){menu_array01[i]}\n";
            }
            return data01[20];
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
