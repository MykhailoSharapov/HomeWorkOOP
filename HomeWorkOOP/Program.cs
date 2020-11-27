using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            NewYearPresent nyp = new NewYearPresent();
            nyp.AddChocolateToPresent(10);
            nyp.AddLolipopsToPresent(10);
            nyp.GetWeightOfPresent();
            Console.WriteLine("------------------------------");
            nyp.PrintAllSweets();
            Console.WriteLine("------------------------------");
            nyp.SortSweetsByWeight();
            Console.WriteLine("------------------------------");
        }
    }
}
