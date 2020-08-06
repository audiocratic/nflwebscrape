using System;
using System.ComponentModel;
using System.Linq;
using HtmlAgilityPack;

namespace NFLWebScrape
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            var doc = web.Load("https://www.pro-football-reference.com/players/J/JackLa00.htm");

            var tableDiv = doc.GetElementbyId("all_passing");

            var rows = tableDiv.QuerySelectorAll("table.stats_table tbody tr");

            foreach (var row in rows)
            {
                var year = row
                    .SelectSingleNode("th[@data-stat= 'year_id']")
                    .ChildNodes
                    .First()
                    .InnerText
                    .Trim();

                var age = row.SelectSingleNode("td[@data-stat= 'age']").InnerText.Trim();
                var team = row.SelectSingleNode("td[@data-stat= 'team']").InnerText.Trim();
                var pos = row.SelectSingleNode("td[@data-stat= 'pos']").InnerText.Trim();
                var number = row.SelectSingleNode("td[@data-stat= 'uniform_number']").InnerText.Trim();
                var games = row.SelectSingleNode("td[@data-stat= 'g']").InnerText.Trim();
                var started = row.SelectSingleNode("td[@data-stat= 'gs']").InnerText.Trim();
                var record = row.SelectSingleNode("td[@data-stat= 'qb_rec']").InnerText.Trim();
                var completions = row.SelectSingleNode("td[@data-stat= 'pass_cmp']").InnerText.Trim();
                var attempts = row.SelectSingleNode("td[@data-stat= 'pass_att']").InnerText.Trim();
                var completionPercent = row.SelectSingleNode("td[@data-stat= 'pass_cmp_perc']").InnerText.Trim();
                var passYards = row.SelectSingleNode("td[@data-stat= 'pass_yds']").InnerText.Trim();
                var passTDs = row.SelectSingleNode("td[@data-stat= 'pass_td']").InnerText.Trim();
                var passTDPerc = row.SelectSingleNode("td[@data-stat= 'pass_td_perc']").InnerText.Trim();
                var interceptions = row.SelectSingleNode("td[@data-stat= 'pass_int']").InnerText.Trim();
                var intPerc = row.SelectSingleNode("td[@data-stat= 'pass_int_perc']").InnerText.Trim();
                var firstDowns = row.SelectSingleNode("td[@data-stat= 'pass_first_down']").InnerText.Trim();
                var passLong = row.SelectSingleNode("td[@data-stat= 'pass_long']").InnerText.Trim();
                var yardsPer = row.SelectSingleNode("td[@data-stat= 'pass_yds_per_att']").InnerText.Trim();
                var adjYardsPer = row.SelectSingleNode("td[@data-stat= 'pass_adj_yds_per_att']").InnerText.Trim();
                var yardsPerComp = row.SelectSingleNode("td[@data-stat= 'pass_yds_per_cmp']").InnerText.Trim();
                var yardsPerGame = row.SelectSingleNode("td[@data-stat= 'pass_yds_per_g']").InnerText.Trim();
                var rating = row.SelectSingleNode("td[@data-stat= 'pass_rating']").InnerText.Trim();
                var qbr = row.SelectSingleNode("td[@data-stat= 'qbr']").InnerText.Trim();
                var sacks = row.SelectSingleNode("td[@data-stat= 'pass_sacked']").InnerText.Trim();
                var sackYards = row.SelectSingleNode("td[@data-stat= 'pass_sacked_yds']").InnerText.Trim();
                var passNet = row.SelectSingleNode("td[@data-stat= 'pass_net_yds_per_att']").InnerText.Trim();
                var adjPassNet = row.SelectSingleNode("td[@data-stat= 'pass_adj_net_yds_per_att']").InnerText.Trim();
                var sackedPerc = row.SelectSingleNode("td[@data-stat= 'pass_sacked_perc']").InnerText.Trim();
                var comebacks = row.SelectSingleNode("td[@data-stat= 'comebacks']").InnerText.Trim();
                var winningDrives = row.SelectSingleNode("td[@data-stat= 'gwd']").InnerText.Trim();
                var av = row.SelectSingleNode("td[@data-stat= 'av']").InnerText.Trim();
                string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20} {21} {22} {23} {24} {25} {26} {27} {28} {29} {30} {31}", year, age, team, pos, number, games, started, record, completions, attempts, completionPercent, passYards, passTDs, passTDPerc, interceptions, intPerc, firstDowns, passLong, yardsPer, adjYardsPer, yardsPerComp, yardsPerGame, rating, qbr, sacks, sackYards, passNet, adjPassNet, sackedPerc, comebacks, winningDrives, av).ToList();

                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20} {21} {22} {23} {24} {25} {26} {27} {28} {29} {30} {31}", year, age, team, pos, number, games, started, record, completions, attempts, completionPercent, passYards, passTDs, passTDPerc, interceptions, intPerc, firstDowns, passLong, yardsPer, adjYardsPer, yardsPerComp, yardsPerGame, rating, qbr, sacks, sackYards, passNet, adjPassNet, sackedPerc, comebacks, winningDrives, av);
            }
        }
    }
}
