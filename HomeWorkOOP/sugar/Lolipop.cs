using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Lolipop : Sweet
    {
        public Lolipop(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, string filling) : base(name, weight, sugarContentPercent, shape, manufacturer, cost)
        {
            Filling = filling;
        }
        public string Filling { get; private set; }        
    }
}
