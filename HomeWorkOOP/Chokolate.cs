using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Chokolate : Sweet
    {
        public Chokolate(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, DateTime expiration) : base(name, weight, sugarContentPercent, shape, manufacturer, cost)
        {
            Expiration = expiration;
            if (Expiration > DateTime.Now)
            {
                Condition = true;
            }
            else
            {
                Condition = false;
            }
        }
        public DateTime Expiration { get; set; }
        public bool Condition { get; private set; }
    }
}
