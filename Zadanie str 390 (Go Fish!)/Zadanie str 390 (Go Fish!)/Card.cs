using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_390__Go_Fish__
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
        private static string[] names0 = new string[]
            {"","dwójek","trójek","czwórek","piątek","szóstek","siódemek","ósemek",
                "dziewiątek","dziesiątek","waletów","dam","króli","asów"};
        private static string[] names1 = new string[]
            {"","dwójkę","trójkę","czwórkę","piątkę","szóstkę","siódemkę","ósemkę",
                "dziewiątkę","dziesiątkę","waleta","damę","króla","asa" };
        private static string[] names2AndMore = new string[]
            {"", "dwójki","trójki","czwórki","piątki","szóstki","siódemki","ósemki",
                "dziewiątki","dziesiątki","walety","damy","króle","asy" };

        public static string Plural(cardGrade grade, int count)
        {
            if (count == 0)
                return names0[(int)grade];
            if (count == 1)
                return names1[(int)grade];
            else
                return names2AndMore[(int)grade];

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


