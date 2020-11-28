using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            NewYearPresent nyp = new NewYearPresent();
            nyp.AddChocolateToPresent(10);
            nyp.AddLolipopsToPresent(10);
            nyp.AddCoockieToPresent(10);
            nyp.GetWeightOfPresent();
            Console.WriteLine("------------------------------");
            nyp.PrintAllSweets();
            Console.WriteLine("------------------------------");
            nyp.SortSweetsByWeight();
            Console.WriteLine("------------------------------");
        }
    }
}
