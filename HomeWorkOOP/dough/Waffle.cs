using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Waffle : Dough
    {
        public Waffle()
        {

        }
        public Waffle(double flourCount, string name, double sugarCount, double cost, string manufacturer, string syropName) : base(flourCount, name, sugarCount, cost, manufacturer)
        {
            SyropName = syropName;
        }
        public string SyropName { get; set; }
        public override string AmIharmful()
        {
            return "No, but ne yvlekysa";
        }
    }
}
