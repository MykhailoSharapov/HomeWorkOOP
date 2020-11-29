using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    interface IDough : IProduct
    {
        double FlourCount { get; set; }
        double SugarCount { get; set; }
        string AmIharmful();
    }
}
