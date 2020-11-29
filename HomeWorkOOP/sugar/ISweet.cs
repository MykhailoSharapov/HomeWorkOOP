using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    interface ISweet : IProduct
    {
        double Weight { get; set; }
        int SugarContentPercent { get; set; }
        string Shape { get; set; }
    }
}
