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
        private List<Player> players;
        private Deck stock;
        private Dictionary<cardGrade, Player> groups;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox texBoxOnForm )

        {
            Random random = new Random();
            this.textBoxOnForm = texBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, texBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, texBoxOnForm));
            groups = new Dictionary<cardGrade, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }
       
        private void Deal()
        {
            for (int type = 0; type <= 3; type++)
                for (int grade = 1; grade <= 13; grade++)
                    stock.Add(new Card((cardGrade)grade, (cardType)type));

            foreach (Player player in players)
                for (int i = 0; i < 5; i++)
                    player.TakeCard(stock.Remove());
            foreach (Player player in players)
                PullOutGroups(player);
                    
        }
        
        public bool PlayOneRound (int selecterdPlayerCard)
        {
            cardGrade cardToAsk = players[0].Peek(selecterdPlayerCard).Grade;
            foreach (Player player in players)
            {
                int playersIndex = players.IndexOf(player);
                if (playersIndex == 0)
                    player.AskForACard(players, 0, stock, cardToAsk);
                else
                    player.AskForACard(players, playersIndex, stock);
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
            foreach (Player player in players)
            {

                foreach (cardGrade grade in groups.Keys)
                    describedGroups += player.Name + " ma grupę " + Card.Plural(grade, 2) + Environment.NewLine;
                return describedGroups;
            }
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

        }

                               
              


            
                

    }
}
