using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class SugarLike : Sweet
    {
        public SugarLike()
        {

        }
        public SugarLike(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, DateTime expiration) : base(name, weight, sugarContentPercent, shape, manufacturer, cost)
        {
            Expiration = expiration;
        }
        public DateTime Expiration { get; set; }
        public bool Condition
        {
            get
            {
                return (Expiration > DateTime.Now) ? true : false;
            }
        }
        public override bool IsCarriesCaller()
        {
            return false;
        }
        public override string MyUniqeName()
        {
            return "second name";
        }
    }
}
