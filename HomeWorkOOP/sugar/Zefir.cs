using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Zefir : SugarLike
    {
        public Zefir(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, DateTime expiration, int beatenEggPercent) : base(name, weight, sugarContentPercent, shape, manufacturer, cost, expiration)
        {
            BeatenEggPercent = beatenEggPercent;
        }
        public int BeatenEggPercent { get; private set; }
        public override string MyUniqeName()
        {
            return "Fourth name";
        }
    }
}
