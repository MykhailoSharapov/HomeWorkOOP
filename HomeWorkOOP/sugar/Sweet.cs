using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    interface ISweet
    {
        double Weight { get; set; }
        int SugarContentPercent { get; set; }
        string Shape { get; set; }
        string Name { get; set; }
        string Manufacturer { get; set; }
        double Cost { get; set; }
        string MyUniqeName();
    }

    public abstract class Sweet : ISweet
    {
        public Sweet(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost)
        {
            Name = name;
            Weight = weight;
            SugarContentPercent = sugarContentPercent;
            Shape = shape;
            Manufacturer = manufacturer;
            Cost = cost;
        }
        public double Weight { get; set; }
        public int SugarContentPercent { get; set; }
        public string Shape { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Cost { get; set; }
        public virtual bool IsCarriesCaller()
        {
            return true;
        }
        public virtual string MyUniqeName()
        {
            return "fisrt name for cream and lolipos";
        }
    }
}
