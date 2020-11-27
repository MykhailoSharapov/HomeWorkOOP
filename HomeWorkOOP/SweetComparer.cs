using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    class SweetComparer : IComparer<Sweet>
    {
        public int Compare(Sweet s1, Sweet s2)
        {
            if (s1.SugarContentPercent > s2.SugarContentPercent)
                return 1;
            else if (s1.SugarContentPercent < s2.SugarContentPercent)
                return -1;
            else
                return 0;
        }
    }
}
