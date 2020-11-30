// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        private static void Main(string[] args)
        {
            NewYearPresent nyp = new NewYearPresent();
            nyp.AddChocolateToPresent(10);
            nyp.AddLolipopsToPresent(10);
            nyp.AddCoockieToPresent(10);
            nyp.AddZefirToPresent(10);
            nyp.GetWeightOfPresent();
            Console.WriteLine("------------------------------");
            nyp.PrintAllSweets();
            Console.WriteLine("------------------------------");
            nyp.SortSweetsByWeight();
            Console.WriteLine("------------------------------");
        }
    }
}
