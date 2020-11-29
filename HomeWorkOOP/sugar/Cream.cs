using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Cream : SugarLike
    {
        public Cream(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, DateTime expiration, string butter) : base(name, weight, sugarContentPercent, shape, manufacturer, cost, expiration)
        {
            Butter = butter;
        }
        public string Butter { get; private set; }
    }
}
