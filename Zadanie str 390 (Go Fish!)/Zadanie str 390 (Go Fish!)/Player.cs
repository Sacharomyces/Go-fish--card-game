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
        public IEnumerable<string> GetCardNames() { return cards.GetCardsNames(); }
        public void SortHand() { cards.SortByGrade(); }
        public void TakeCard(Card card) => cards.Add(card); 

        public Player(String name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            textBoxOnForm.Text += "" + Name + " dołączył do gry."+Environment.NewLine ;
            this.cards = new Deck();


        }
        
        

        public Card Peek (int cardNumber) { return cards.Peek(cardNumber); }
        
        

      

        public cardGrade GetRandomGrade()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Grade; 
            

        }

        public Deck DoYouHaveAny(cardGrade grade)
        {
            Deck cardsToReturn = new Deck();
            cardsToReturn = cards.PullOutGrades(grade);
            return cardsToReturn;
            textBoxOnForm.Text += Name + " ma " + cardsToReturn.Count + " " + Card.Plural(grade, cardsToReturn.Count) + Environment.NewLine; 

        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                    cards.Add(stock.Remove());
                
                    cardGrade randomGrade = GetRandomGrade();
                    AskForACard(players, myIndex, stock, randomGrade);
                
            }
        }

        public void AskForACard (List<Player> players, int myIndex, Deck stock, cardGrade grade)
        {
            textBoxOnForm.Text += "" + Name + " pyta czy ktoś ma " + Card.Plural(grade, 2)+Environment.NewLine;
            int totalCardsGiven = 0;
            for (int playerIndex = 0; playerIndex < players.Count; playerIndex++)
            {
                
                if (playerIndex != myIndex)
                {
                    Player player = players[playerIndex];
                    Deck cardsToGive = player.DoYouHaveAny(grade);
                    totalCardsGiven += cardsToGive.Count;
                    while (cardsToGive.Count > 0)
                        cards.Add(cardsToGive.Remove());
                }
                

            }
                if (totalCardsGiven == 0 && stock.Count > 0)
                {
                    textBoxOnForm.Text += Name + " musi dobrać kartę ( idzie na ryby!)" + Environment.NewLine;
                    cards.Add(stock.Remove());
                }
                else
                textBoxOnForm.Text += Name + " otrzymał kart: " + totalCardsGiven + Environment.NewLine;
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
