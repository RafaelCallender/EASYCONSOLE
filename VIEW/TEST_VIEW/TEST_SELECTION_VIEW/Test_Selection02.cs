using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_HELPER;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_MAIN_VIEW;
using EASYPROJECT01.EASY_CALLENDER01.SERVICES.FILES.FILE_MANAGER;

namespace EASYPROJECT01.EASYCONSOLE.VIEW.TEST_VIEW.TEST_SELECTION_VIEW
{
    internal class Test_Selection02
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();

        private static string menu_string =
                                          $"API01\n" +
                   $"API02\n" +
                   $"API03\n" +
                   $"Client_Textfile01\n" +
                   $"Client_Textfile02\n" +
                   $"Client_Textfile03\n" +
                   $"Client_Textfile04\n" +
                   $"Client_Textfile05\n" +
                   $"cloudinary_com_text01\n" +
                   $"cloudinary_com_text02\n" +
                   $"cloudinary_com_text03\n" +
                   $"Admin_text01\n" +
                   $"Admin_text02\n" +
                   $"Admin_text03\n" +
                   $"Admin_text04\n" +
                   $"Linux_text04\n" +
                   $"Linux_text05\n" +
                   $"Linux_text06\n" +
                   $"list all textfiles\n" +
                   $"list all textfiles 01\n" +
                   $"list all saved textfiles\n" +
                   $"list all saved textfiles 01\n" +
                   $"list all directories\n" +
                    $"list all directories 01\n" +
                    $"data reader\n" +
$"data reader 01\n" +
$"file array\n" +
                   $"back\n";


        private static string[] menu_array = menu_string.Split("\n");

        private static Dictionary<string, Action> _commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase);
        public Test_Selection02()
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

                case "API01":
                    _commands.Add(procedure, API01);
                    break;
                case "API02":
                    _commands.Add(procedure, API02);
                    break;
                case "API03":
                    _commands.Add(procedure, API03);
                    break;
                case "Client_Textfile01":
                    _commands.Add(procedure, Client_Textfile01);
                    break;
                case "Client_Textfile02":
                    _commands.Add(procedure, Client_Textfile02);
                    break;
                case "Client_Textfile03":
                    _commands.Add(procedure, Client_Textfile03);
                    break;
                case "Client_Textfile04":
                    _commands.Add(procedure, Client_Textfile04);
                    break;
                case "Client_Textfile05":
                    _commands.Add(procedure, Client_Textfile05);
                    break;
                case "cloudinary_com_text01":
                    _commands.Add(procedure, cloudinary_com_text01);
                    break;
                case "cloudinary_com_text02":
                    _commands.Add(procedure, cloudinary_com_text02);
                    break;
                case "cloudinary_com_text03":
                    _commands.Add(procedure, cloudinary_com_text03);
                    break;
                case "Admin_text01":
                    _commands.Add(procedure, Admin_text01);
                    break;
                case "Admin_text02":
                    _commands.Add(procedure, Admin_text02);
                    break;
                case "Admin_text03":
                    _commands.Add(procedure, Admin_text03);
                    break;
                case "Admin_text04":
                    _commands.Add(procedure, Admin_text04);
                    break;
                case "Linux_text04":
                    _commands.Add(procedure, Linux_text04);
                    break;
                case "Linux_text05":
                    _commands.Add(procedure, Linux_text05);
                    break;
                case "Linux_text06":
                    _commands.Add(procedure, Linux_text06);
                    break;
                case "list all textfiles":
                    _commands.Add(procedure, list_all_textfiles);
                    break;
                case "list all textfiles 01":
                    _commands.Add(procedure, list_all_textfiles01);
                    break;
                case "list all saved textfiles":
                    _commands.Add(procedure, list_all_saved_textfiles);
                    break;
                case "list all saved textfiles 01":
                    _commands.Add(procedure, list_all_saved_textfiles01);
                    break;
                case "list all directories":
                    _commands.Add(procedure, list_all_directories);
                    break;
                case "list all directories 01":
                    _commands.Add(procedure, list_all_directories_01);
                    break;
                case "data reader":
                    _commands.Add(procedure, data_reader);
                    break;
                case "data reader 01":
                    _commands.Add(procedure, data_reader_01);
                    break;
                        case "file array":
                    _commands.Add(procedure, file_array);
                    break;
                case "back":
                    _commands.Add(procedure, back);
                    break;

            }
        }
        private void data_reader()
        {
            foreach (string a in File_Helper01.data01)
            {
                Console.WriteLine($"{a}\n");
            }

        }
        
        private void file_array()
        {
            foreach (string a in File_Helper01.file_array01)
            {
                Console.WriteLine($"{a}\n");
            }

        }
        private void data_reader_01()
        {
            Console.WriteLine(

    $"Admin:{File_Helper01.data01[(int)File_Helper01.text_string.Admin]}\n" +
      $"API: {File_Helper01.data01[(int)File_Helper01.text_string.API]}\n" +
$"Chemistry: {File_Helper01.data01[(int)File_Helper01.text_string.Chemistry]}\n" +
$"Chemistry01: {File_Helper01.data01[(int)File_Helper01.text_string.Chemistry01]}\n" +
$"Client_Textfile01: {File_Helper01.data01[(int)File_Helper01.text_string.Client_Textfile01]}\n" +
$"cloudinary_com: {File_Helper01.data01[(int)File_Helper01.text_string.cloudinary_com]}\n" +
$"GMAIL_CREDENTIAL: {File_Helper01.data01[(int)File_Helper01.text_string.GMAIL_CREDENTIAL]}\n" +
$"hairstyle_info_01: {File_Helper01.data01[(int)File_Helper01.text_string.hairstyle_info_01]}\n" +
$"hairstyle_info_02: {File_Helper01.data01[(int)File_Helper01.text_string.hairstyle_info_02]}\n" +
$"Language_Abbreviation: {File_Helper01.data01[(int)File_Helper01.text_string.Language_Abbreviation]}\n" +
$"Language_Name:{File_Helper01.data01[(int)File_Helper01.text_string.Language_Name]}\n" +
$"Sql_info01:{File_Helper01.data01[(int)File_Helper01.text_string.Sql_info01]}\n" +
$"The_Bible_KJV:{File_Helper01.data01[(int)File_Helper01.text_string.The_Bible_KJV]}\n" +
$"The_Book_of_Enoch:{File_Helper01.data01[(int)File_Helper01.text_string.The_Book_of_Enoch]}\n" +
$"The_Book_of_Jubilees:{File_Helper01.data01[(int)File_Helper01.text_string.The_Book_of_Jubilees]}\n" +
$"nba_text:{File_Helper01.data01[(int)File_Helper01.text_string.nba_text]}\n" +
$"Linux01:{File_Helper01.data01[(int)File_Helper01.text_string.Linux01]}\n" +
$"mytextfile01:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile01]}\n" +
$"mytextfile02:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile02]}\n" +
$"mytextfile03:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile03]}\n" +
$"mytextfile04:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile04]}\n" +
$"mytextfile05:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile05]}\n" +
$"mytextfile06:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile06]}\n" +
$"mytextfile07:{File_Helper01.data01[(int)File_Helper01.text_string.mytextfile07]}\n" +
$"aboutus:{File_Helper01.data01[(int)File_Helper01.text_string.aboutus]}\n"

    );

        }
        private void API01()
        {
            Console.WriteLine($"{File_Manger01.API01}\n");
        }
        private void API02()
        {

            Console.WriteLine($"{File_Manger01.API02}\n");
        }
        private void API03()
        {

            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Client_Textfile01()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Client_Textfile02()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Client_Textfile03()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Client_Textfile04()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Client_Textfile05()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void cloudinary_com_text01()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void cloudinary_com_text02()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void cloudinary_com_text03()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Admin_text01()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Admin_text02()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Admin_text03()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Admin_text04()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Linux_text04()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Linux_text05()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void Linux_text06()
        {
            Console.WriteLine($"{File_Manger01.API03}\n");
        }
        private void list_all_saved_textfiles()
        {
            Console.WriteLine($"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile01]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile02]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile03]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile04]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile05]}\n" +
                              $"{File_Helper01.SavedTextDirectory[(int)File_Helper01.SavedTextDirectory_strings.mytextfile06]}\n"



            );

        }

        private void list_all_saved_textfiles01()
        {
            Console.WriteLine($"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile01]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile02]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile03]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile04]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile05]}\n" +
                              $"{File_Helper01.SavedTextDirectory01[(int)File_Helper01.SavedTextDirectory_strings.mytextfile06]}\n"



            );

        }

        private void list_all_textfiles()
        {
            int count = 0;
            foreach (string a in File_Helper01.text_files_list)
            {
                count++;
                Console.WriteLine($"{count}.) {a}");
            }


        }
        private void list_all_textfiles_01()
        {
            Console.WriteLine(

      $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Admin]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.API]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Chemistry]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Chemistry01]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Client_Textfile01]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.cloudinary_com]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.GMAIL_CREDENTIAL]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.hairstyle_info_01]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.hairstyle_info_02]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Language_Abbreviation]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Language_Name]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Sql_info01]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Bible_KJV]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Book_of_Enoch]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Book_of_Jubilees]}\n" +
 $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.nba_text]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Linux01]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile01]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile02]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile03]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile04]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile05]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile06]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile07]}\n" +
  $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.aboutus]}\n"






      );


        }
        private void list_all_textfiles01()
        {

            Console.WriteLine(

            $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Admin]}\n" +
              $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.API]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Chemistry]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Chemistry01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Client_Textfile01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.cloudinary_com]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.GMAIL_CREDENTIAL]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.hairstyle_info_01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.hairstyle_info_02]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Language_Abbreviation]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Language_Name]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Sql_info01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Bible_KJV]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Book_of_Enoch]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.The_Book_of_Jubilees]}\n" +
       $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.nba_text]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.Linux01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile01]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile02]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile03]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile04]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile05]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile06]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.mytextfile07]}\n" +
        $"{File_Helper01.text_files_list[(int)File_Helper01.text_string.aboutus]}\n"






            );



        }
        private void list_all_directories()
        {
            foreach (string a in File_Helper01.directories)
            {
                Console.WriteLine($"{a}\n");
            }
        }
        private void list_all_directories_01()
        {
            Console.WriteLine(
       $"{File_Helper01.directories[(int)File_Helper01.directories_string.dog_breads]}\n" +
   $"{File_Helper01.directories[(int)File_Helper01.directories_string.cashapp01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_group_face01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_single_face01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_single_face02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.default_single_face03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.cashapp02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.cashapp03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.EYE_ICON01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.paypal01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.paypal02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.paypal03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.venmo02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.venmo03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.zelleimage01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.zelleimages02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.learning_icon01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.person01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Easy_Callender_page_1]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.venmo01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.GMAIL01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Book_of_Jasher]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.book_of_judith]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Dead_Sea_Scrolls]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Enoch]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Jubilees]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_TOB]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Admin]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.API]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Chemistry]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Chemistry01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Client_Textfile01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.cloudinary_com]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.GMAIL_CREDENTIAL]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.hairstyle_info_01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.hairstyle_info_02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Language_Abbreviation]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Language_Name]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Sql_info01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Bible_KJV]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Enoch_pdf]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.The_Book_of_Jubilees_pdf]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.nba_text]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.Linux01]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile01]}\n" +
           $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile02]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile03]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile04]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile05]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile06]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.mytextfile07]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.aboutus]}\n" +
            $"{File_Helper01.directories[(int)File_Helper01.directories_string.resume01]}\n"

        );
        }
        private void back()
        {
            new Test_Main_View01();
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
