using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_382__decks_exchange_
{
    class Deck
    {
        
        private List<Card> cards;
        private Random random = new Random();
        public Deck(CardCompearer comparer)
        {
            cards = new List<Card>();

            for (int type = 0; type <= 3; type++)
                for (int value = 1; value <= 13; value++)
                    cards.Add(new Card((cardGrade)value, (cardType)type));

            cards.Sort(comparer);
        }
        public Deck(Random random, CardCompearer comparer)
        {
            cards = new List<Card>();

            for (int i = random.Next(1,10); i <= 10; i++)
            {
                
                cards.Add(new Card((cardGrade)random.Next(1, 13), (cardType)random.Next(4)));
            }

            cards.Sort(comparer);

        }
        public int Count { get { return cards.Count; } }
        public List<Card> Cards { get { return cards; }  }

        public Card Peek (int cardNumber)
        {
            return cards[cardNumber];
        }

        public void Remove()
        {
            Remove (cards[0]);       
        }

        public void Add (Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }
        public void Remove (Card cardToMove)

        {
                cards.Remove(cardToMove);
            
        }

        public bool ContainsValue (cardGrade grade)
        {
            foreach (Card card in cards) 
                if (card.Grade == grade)
                    return true;
                
               return false;
        }

        public Deck PullOutGrades(CardCompearer comparer, cardGrade grade)
        {
            Deck deckToReturn = new Deck(comparer);
            for (int i = cards.Count - 1; i >= 0; i--)

                if (cards[i].Grade == grade)
                {
                    deckToReturn.Add(cards[i]);
                    cards.Remove(cards[i]);

                }
            return deckToReturn;
        }

       public bool HasGroup(cardGrade grade)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
                if (card.Grade == grade)
                    NumberOfCards++;
            if (NumberOfCards == 4)
                return true;
            else
                return false;

        }
        public void SortByGrade()
        {
            cards.Sort(new CardCompearer());
        }
    }
}
