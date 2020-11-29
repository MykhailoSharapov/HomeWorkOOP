using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Dough : IDough
    {
        public Dough(double flourCount, string name, double sugarCount, double cost, string manufacturer)
        {
            FlourCount = flourCount;
            Name = name;
            SugarCount = sugarCount;
            Cost = cost;
            Manufacturer = manufacturer;
        }
        public Dough()
        {

        }
        public double FlourCount { get; set; }
        public string Name { get; set; }
        public double SugarCount { get; set; }
        public double Cost { get; set; }
        public string Manufacturer { get; set; }
        public virtual string AmIharmful()
        {
            return "actualy no";
        }
    }
}
