using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_382__decks_exchange_
{
    class Card
    {
        public Card (cardGrade grade,cardType type)
        {
            Grade = grade;
            Type = type;
        }

        public override string ToString()
        {
            return Name;
        }
        public cardGrade Grade { get; set; }
        public cardType Type { get; set; }

        public string Name
        {
            get
            {
                return Grade.ToString() +" "+ Type.ToString();
            }
        }
    }
   enum cardGrade
    {
        Dwójka = 1,Trójka,Czwórka,Piątka,Szóstka,Siódemka,Ósemka,Dziewiątka,Dziesiątka,Walet,Dama,Król,As
    }
    enum cardType
    {
        Karo,Pik,Kier,Trefl
    } 
}

