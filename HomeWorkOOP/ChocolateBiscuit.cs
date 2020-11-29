using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class ChocolateBiscuit : ISweet, IDough
    {
        public ChocolateBiscuit(double weight, int sugarContentPercent, string shape, string name, string manufacturer, double cost, double flourCount, double sugarDoughtCount)
        {
            Weight = weight;
            SugarContentPercent = sugarContentPercent;
            Shape = shape;
            Name = Name;
            Manufacturer = manufacturer;
            Cost = cost;
            FlourCount = flourCount;
            SugarCount = sugarDoughtCount;
        }
        public double Weight { get ; set ; }
        public int SugarContentPercent { get; set; }
        public string Shape { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Cost { get; set; }
        public double FlourCount { get; set; }
        public double SugarCount { get; set; }

        public string AmIharmful()
        {
            return "Yes, only for polymorfizm";
        }

        public string MyUniqeName()
        {
            return "best tortik";
        }
    }
}
