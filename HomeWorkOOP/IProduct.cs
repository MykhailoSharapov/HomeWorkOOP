using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    interface IProduct
    {
        double Cost { get; set; }
        string Name { get; set; }
        string Manufacturer { get; set; }
    }
}
