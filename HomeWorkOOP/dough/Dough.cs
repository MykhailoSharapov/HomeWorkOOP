using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    interface IDough
    {
        double FlourCount { get; set; }
        string Name { get; set; }
        double SugarCount { get; set; }
        double Cost { get; set; }
        string AmIharmful();
    }

    public class Dough : IDough
    {
        public Dough(double flourCount, string name, double sugarCount, double cost)
        {
            FlourCount = flourCount;
            Name = name;
            SugarCount = sugarCount;
            Cost = Cost;
        }
        public double FlourCount { get; set; }
        public string Name { get; set; }
        public double SugarCount { get; set; }
        public double Cost { get; set; }
        public virtual string AmIharmful()
        {
            return "actualy no";
        }
    }

}
