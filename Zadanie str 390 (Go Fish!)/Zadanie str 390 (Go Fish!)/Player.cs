using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_str_390__Go_Fish__
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        public int CardCount { get { return cards.Count; } }
        public IEnumerable<string> GetCardNames()
        { return cards.GetCardNames(); }

        public Card Peek (int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByGrade(); }
        public Player (String name, Random random, TextBox textBoxOnForm)
        {

        }

        public IEnumerable<cardGrade> PullOutGroups()
        {

        }

        public cardGrade GetRandomGrade()
        {

        }

        public Deck DoYouHaveAny(cardGrade grade)
        {

        }

        public void AskForACard (List<Player> players, int myIndex, Deck stock, cardGrade grade )
        {
            // dwie overloaded metody, pierwsza wykonywan gdy przeciwnik pyta wtedy 
           // sprawdza jego reke w celu wybrania karty i spytania o nia
           //druga używana przez gracza po wygraniu karty
        }

        public IEnumerable<cardGrade> PullOutGroups()
        {
            List<cardGrade> groups = new List<cardGrade>();
            for (int i = 1; i <= 13; i++)
            {
                cardGrade grade = (cardGrade)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Grade == grade)
                        howMany++;
                if (howMany ==4)
                {
                    groups.Add(grade);           //groups jest listą cadrGrade
                    cards.PullOutGrades(grade);  //metoda usuwa grupy z ręki
                }

            }
            return groups;
            
        }
    }
}
