using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_str_390__Go_Fish__

{
    class CardCompearer : IComparer<Card>

    {
        public int Compare(Card x, Card y)
        {
           
            if (x.Grade > y.Grade)
                return 1;
            else if (x.Grade < y.Grade)
                return -1;
            else
                if (x.Type > y.Type)
                return 1;
            else if (x.Type < y.Type)
                return -1;
            else
                return 0;

        }
    }
}
