using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_str_390__Go_Fish__
{
    class Game
    {
        Random random = new Random();
        private List<Player> players;
        private Deck stock;
        private Dictionary<cardGrade, Player> groups;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox texBoxOnForm)

        {
            RandomComparer comparer = new RandomComparer();
            Random random = new Random();
            this.textBoxOnForm = texBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, texBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, texBoxOnForm));
            groups = new Dictionary<cardGrade, Player>();
            stock = new Deck(comparer);
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {

            foreach (Player player in players)
                for (int i = 0; i < 5; i++)
                    player.TakeCard(stock.Remove(random.Next(stock.Count)));
            foreach (Player player in players)
                PullOutGroups(player);

        }


        public bool PlayOneRound(int selecterdPlayerCard)
        {
            cardGrade cardToAsk = players[0].Peek(selecterdPlayerCard).Grade;
            foreach (Player player in players)
            {
                int playersIndex = players.IndexOf(player);
                if (playersIndex == 0)
                    player.AskForACard(players, 0, stock, cardToAsk);
                else
                    player.AskForACard(players, playersIndex, stock);
            }

            foreach (Player player in players)
            {
                int playersIndex = players.IndexOf(player);
                if (PullOutGroups(players[playersIndex]))
                {
                    textBoxOnForm.Text += "" + players[playersIndex].Name + " dobiera rekę" + Environment.NewLine;
                    for (int i = 0; i < 4 && stock.Count > 0; i++)
                        players[playersIndex].TakeCard(stock.Remove());
                }
            }
            players[0].SortHand();
            if (stock.Count == 0)
            {
                textBoxOnForm.Text += "Koniec kart. Gra Skończona" + Environment.NewLine;
                return true;
            }

            else
                return false;
        }
    
        public bool PullOutGroups(Player player)
        {
            IEnumerable<cardGrade> groupsPulled = player.PullOutGroups();
            foreach (cardGrade Grade in groupsPulled)

                groups.Add(Grade, player);
            if (player.CardCount == 0)
                return true;
            else
                return false;
        }

        public string DescribeGroups()
        {
            string describedGroups = "";
           
                foreach (cardGrade grade in groups.Keys)
                    describedGroups += groups[grade].Name + " ma grupę " + Card.Plural(grade, 2) + Environment.NewLine;
            
            return describedGroups;

        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();

            foreach (Player player in players)
                winners.Add(player.Name, 0);

            foreach (cardGrade grade in groups.Keys)
            {
                string name = groups[grade].Name;
                winners[name] += 1;


            }
            int mostGroups = 0;
            string winnerList = "";
            bool tie = false;
            foreach (int groups in winners.Values)
                if (mostGroups < groups)
                    mostGroups = groups;
            foreach (string name in winners.Keys)
                if (winners[name] == mostGroups)
                {
                    if (!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " i ";
                        tie = true;
                    }
                    winnerList += name;
                }
            winnerList += " mając " + mostGroups + " grupy";
            if (tie == true)
                return "Remis, wygrywają "+winnerList;
            else
                return "Wygrywa "+winnerList;
        }
        public IEnumerable<string> GetPlayerCardNames() => players[0].GetCardNames();

        public string DescribePlayersHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " ma " + players[i].CardCount + Card.Plural(players[i].CardCount);
                
                   
            }
            if (stock.Count > 1)
                description += "Ilość pozostałych kart w talii: " + stock.Count;
            else if (stock.Count == 1)
                description += "W talii została jedna karta.";
            else
                description += "W talii nie ma juz kart.";
            return description;





        }
    }
}
