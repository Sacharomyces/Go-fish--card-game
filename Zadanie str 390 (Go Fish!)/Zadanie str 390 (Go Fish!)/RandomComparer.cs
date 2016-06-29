using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_390__Go_Fish__
{
    class RandomComparer : IComparer<Card>
    {
        Random random = new Random();
        public int Compare(Card x, Card y)
        {
            if (x.Grade > y.Grade)
                return random.Next(-1, 1);
            else if (x.Grade < y.Grade)
                return random.Next(-1, 1);
            else
                return random.Next(-1, 1);
        }
    }
}
