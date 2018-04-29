using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Women
{
    class WomanComparerByAge:IComparer<Woman>
    {
        public int Compare (Woman x, Woman y)
        {
            if (x.Age > y.Age)
                return 1;
            else if (x.Age < y.Age)
                return -1;
            else
                return 0;
        }
    }
}
