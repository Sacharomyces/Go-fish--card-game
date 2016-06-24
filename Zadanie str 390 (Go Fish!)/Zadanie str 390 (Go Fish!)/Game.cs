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
        private TextBox texBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox texBoxOnForm )

        {
            Random random = new Random();
            this.texBoxOnForm = texBoxOnForm;
            players = new List<Player>();
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
                player.PullOutGroups();
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



            }
        }

    }
}
