using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Waffle:Dough
    {
        public Waffle(double flourCount, string name, double sugarCount, double cost):base(flourCount,name,sugarCount,cost)
        {
            
        }
        public override string AmIharmful()
        {
            return "No, but ne yvlekysa";
        }
    }
}
