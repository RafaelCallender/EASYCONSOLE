using EASY_CALLENDER01.SERVICES.SECURITY_SERVICES;
using EASY_CALLENDER01.SERVICES.SPORTS_SERVICES.NBA;


namespace EASYCONSOLE.VIEW.SPORTS_VIEW.SPORTS_SELECTION_VIEW.SPORTS_SELECCTION_NBA_VIEW
{
    internal class Sports_Selection_View01
    {
        private static string[] data01 = new string[100];
        private static Security_Services01 Security_Serv01 = new Security_Services01();
        private static Nba_Services01 Nba_Serv01 = new Nba_Services01();
        private int counter01 = 0;
        public Sports_Selection_View01()
        {
            load_Sports_Selection_View01().Wait();
        }
        private string load_Sports_Selection_View01_string()
        {
            return "1.) GET_Seasons\n" +
                        "2.)GET_Leagues\n" +
                        "3.)GET_Games\n" +
                        "4.)GET_Games_between_two_teams\n" +
                        "5.)GET_Games_in_live\n" +
                        "6.)GET_Games_per_season\n" +
                        "7.)GET_Games_per_date\n" +
                        "8.)GET_Games_per_team_and_season\n" +
                        "9.)GET_Games_per_id\n" +
                        "10.)GET_Teams GET_Teams_per_conference\n" +
                        "11.)GET_Teams_per_division\n" +
                        "12.)GET_Teams_per_codeGET_Teams_per_id\n" +
                        "13.)GET_Teams GET_Standings\n" +
                        "14.)GET_Standings_per_conference_and_season\n" +
                        "15.)GET_Standings_per_division_and_season\n" +
                        "16.)GET_Standings_per_team_and_season GET_Games_Statistics\n" +
                        "17.)GET_Teams_Statistics\n" +
                        "18.)GET_Players_Statistics_per_player_and_season\n" +
                        "19.)GET_Players_Statistics_per_team_and_season\n" +
                        "20.)GET_Players_Statistics_per_game_id GET_Search_teams()\n" +
                        "21.)GET_Search_players()\n";
        }
        private async Task load_Sports_Selection_View01()
        {


            Console.WriteLine(load_Sports_Selection_View01_string());
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


                                Console.WriteLine(await Nba_Serv01.GET_Seasons());
                                Console.WriteLine(load_Sports_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 2:


                                Console.WriteLine(await Nba_Serv01.GET_Leagues());
                                Console.WriteLine(load_Sports_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 3:

                                Console.WriteLine($"enter date\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.date_check(data01[3], out data01[24]) == true)
                                    {
                                        data01[4] = await Nba_Serv01.GET_Games(data01[3]);
                                        Console.WriteLine(load_Sports_Selection_View01_string());
                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;

                                    }

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 4:


                                Console.WriteLine(await Nba_Serv01.GET_Games_between_two_teams());
                                Console.WriteLine(load_Sports_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;

                            case 5:


                                Console.WriteLine(await Nba_Serv01.GET_Games_in_live());
                                Console.WriteLine(load_Sports_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;

                            case 6:

                                Console.WriteLine($"enter year\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {
                                        if (Security_Serv01.year_check(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(await Nba_Serv01.GET_Games_per_season(data01[3]));
                                            Console.WriteLine(load_Sports_Selection_View01_string());
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

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }


                            case 7:

                                Console.WriteLine($"enter date\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.date_check(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine(await Nba_Serv01.GET_Games_per_date(data01[3]));
                                        Console.WriteLine(load_Sports_Selection_View01_string());
                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 8:

                                Console.WriteLine($"enter year\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine($"enter team\n");
                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[5], out data01[25]) == true)
                                        {
                                            if (Security_Serv01.string_only_digit(data01[5], out data01[26]) == true)
                                            {
                                                if (Security_Serv01.nba_team_check(data01[5], out data01[27]) == true)
                                                {


                                                    Console.WriteLine(await Nba_Serv01.GET_Games_per_team_and_season(data01[3], data01[5]));
                                                    Console.WriteLine(load_Sports_Selection_View01_string());
                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[27]);
                                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }


                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[26]);
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
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;

                                    }

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 9:

                                Console.WriteLine($"enter team ID\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {
                                        if (Security_Serv01.nba_team_check(data01[3], out data01[25]) == true)
                                        {
                                            data01[4] = await Nba_Serv01.GET_Games_per_id(data01[3]);
                                            Console.WriteLine(data01[4]);
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

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                                break;
                            case 10:


                                Console.WriteLine(await Nba_Serv01.GET_Teams());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                continue;

                            case 11:

                                foreach (var a in Nba_Serv01.data_array)
                                {
                                    counter01++;
                                    data01[2] += $"{counter01}.) {a}\n";
                                }
                                Console.WriteLine($"enter team conference\n {data01[2]}");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine(await Nba_Serv01.GET_Teams_per_conference(int.Parse(data01[3])));
                                        Console.WriteLine(load_Sports_Selection_View01_string());
                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;

                                    }



                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 12:

                                foreach (var a in Nba_Serv01.data_array01)
                                {
                                    counter01++;
                                    data01[2] += $"{counter01}.) {a}\n";
                                }
                                Console.WriteLine($"enter team division\n{data01[2]}");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine(await Nba_Serv01.GET_Teams_per_division(int.Parse(data01[3])));
                                        Console.WriteLine(load_Sports_Selection_View01_string());
                                        data01[1] = Console.ReadLine() ?? string.Empty;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }



                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                                break;
                            case 13:

                                Console.WriteLine($"enter team code\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {
                                        if (Security_Serv01.nba_team_check(data01[3], out data01[25]) == true)
                                        {

                                            data01[4] = await Nba_Serv01.GET_Teams_per_code(int.Parse(data01[3]));
                                            Console.WriteLine(data01[4]);
                                            Console.WriteLine(load_Sports_Selection_View01_string());
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



                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 14:

                                Console.WriteLine($"enter team id\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {
                                        if (Security_Serv01.nba_team_check(data01[3], out data01[25]) == true)
                                        {
                                            Console.WriteLine(await Nba_Serv01.GET_Teams_per_id(int.Parse(data01[3])));
                                            Console.WriteLine(load_Sports_Selection_View01_string());
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



                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 15:
                                

                                Console.WriteLine($"enter team id\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {
                                          if (Security_Serv01.string_only_digit(data01[3], out data01[25]) == true)
                                        {
                                                    
                                        Console.WriteLine(await Nba_Serv01.GET_Teams(int.Parse(data01[3])));
                                        Console.WriteLine(load_Sports_Selection_View01_string());
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



                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 16:
                            

                                Console.WriteLine( $"enter season year\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        if (Security_Serv01.year_check(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(await Nba_Serv01.GET_Standings(int.Parse(data01[3])));
                                            Console.WriteLine(load_Sports_Selection_View01_string());
                                            data01[1] = Console.ReadLine() ?? string.Empty;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[24]);
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



                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 17:



                                Console.WriteLine($"enter season year\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {
                                        if (Security_Serv01.year_check(data01[3], out data01[24]) == true)
                                        {

                                            foreach (var a in Nba_Serv01.data_array)
                                            {
                                                counter01++;
                                                data01[4] += $"{counter01}.) {a}\n";
                                            }
                                            Console.WriteLine($"enter conference\n {data01[4]}");
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
                                            {
                                                if (Security_Serv01.string_only_digit(data01[5], out data01[24]) == true)
                                                {

                                                    data01[6] = await Nba_Serv01.GET_Standings_per_conference_and_season(int.Parse(data01[3]), int.Parse(data01[5]));
                                                    Console.WriteLine(data01[6]);
                                                    Console.WriteLine(load_Sports_Selection_View01_string());
                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[24]);
                                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[23]);
                                                data01[5] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[24]);
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }



                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 18:

                                Console.WriteLine($"enter season year\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {
                                        if (Security_Serv01.year_check(data01[3], out data01[25]) == true)
                                        {
                                        
                                            foreach (var a in Nba_Serv01.data_array01)
                                            {
                                                counter01++;
                                                data01[4] += $"{counter01}.) {a}\n";
                                            }
                                            Console.WriteLine($"enter divison\n{data01[4]}");
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
                                            {
                                                if (Security_Serv01.string_only_digit(data01[5], out data01[24]) == true)
                                                {

                                                    data01[6] = await Nba_Serv01.GET_Standings_per_division_and_season(int.Parse(data01[3]), int.Parse(data01[5]));
                                                    Console.WriteLine(data01[6]);
                                                    Console.WriteLine(load_Sports_Selection_View01_string());
                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[24]);
                                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[23]);
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
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                                break;
                            case 19:



                                Console.WriteLine($"enter season year\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine($"enter team id");

                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
                                        {
                                            if (Security_Serv01.string_only_digit(data01[5], out data01[24]) == true)
                                            {


                                                Console.WriteLine(await Nba_Serv01.GET_Standings_per_team_and_season(int.Parse(data01[3]), int.Parse(data01[5])));
                                                Console.WriteLine(load_Sports_Selection_View01_string());
                                                data01[1] = Console.ReadLine() ?? string.Empty;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[24]);
                                                data01[3] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[23]);
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

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }
                                break;
                            case 20:


                                Console.WriteLine(await Nba_Serv01.GET_Games_Statistics());
                                Console.WriteLine(load_Sports_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 21:


                                Console.WriteLine($"enter team ID\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine($"enter season year\n");
                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[5], out data01[23]) == true)
                                        {
                                            if (Security_Serv01.string_only_digit(data01[5], out data01[24]) == true)
                                            {

                                                Console.WriteLine(await Nba_Serv01.GET_Teams_Statistics(int.Parse(data01[3]), int.Parse(data01[5])));
                                                Console.WriteLine(load_Sports_Selection_View01_string());
                                                data01[1] = Console.ReadLine() ?? string.Empty;
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[24]);
                                                data01[5] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[24]);
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;

                                    }

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 22:


                                Console.WriteLine("enter season year");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        if (Security_Serv01.year_check(data01[3], out data01[25]) == true)
                                        {

                                            Console.WriteLine(await Nba_Serv01.GET_Players_Statistics_per_player_and_season(int.Parse(data01[3])));
                                            Console.WriteLine(load_Sports_Selection_View01_string());
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

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 23:


                                Console.WriteLine($"enter team ID\n");
                                data01[3] = Console.ReadLine() ?? string.Empty;
                                if (Security_Serv01.empty_string(data01[3], out data01[23]) == true)
                                {
                                    if (Security_Serv01.string_only_digit(data01[3], out data01[24]) == true)
                                    {

                                        Console.WriteLine($"enter season year\n");
                                        data01[5] = Console.ReadLine() ?? string.Empty;
                                        if (Security_Serv01.empty_string(data01[5], out data01[26]) == true)
                                        {
                                            if (Security_Serv01.string_only_digit(data01[5], out data01[27]) == true)
                                            {

                                                if (Security_Serv01.year_check(data01[5], out data01[28]) == true)
                                                {

                                                    Console.WriteLine(await Nba_Serv01.GET_Players_Statistics_per_team_and_season(int.Parse(data01[3]), int.Parse(data01[5])));
                                                    Console.WriteLine(load_Sports_Selection_View01_string());
                                                    data01[1] = Console.ReadLine() ?? string.Empty;
                                                    break;

                                                }
                                                else
                                                {
                                                    Console.WriteLine(data01[28]);
                                                    data01[5] = Console.ReadLine() ?? string.Empty;
                                                    continue;
                                                }

                                            }
                                            else
                                            {
                                                Console.WriteLine(data01[27]);
                                                data01[5] = Console.ReadLine() ?? string.Empty;
                                                continue;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine(data01[26]);
                                            data01[5] = Console.ReadLine() ?? string.Empty;
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(data01[24]);
                                        data01[3] = Console.ReadLine() ?? string.Empty;
                                        continue;

                                    }

                                }
                                else
                                {
                                    Console.WriteLine(data01[23]);
                                    data01[3] = Console.ReadLine() ?? string.Empty;
                                    continue;
                                }

                            case 24:


                                Console.WriteLine(await Nba_Serv01.GET_Players_Statistics_per_game_id());
                                Console.WriteLine(load_Sports_Selection_View01_string());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                break;
                            case 26:


                                Console.WriteLine(await Nba_Serv01.GET_Search_players());
                                data01[1] = Console.ReadLine() ?? string.Empty;
                                continue;

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