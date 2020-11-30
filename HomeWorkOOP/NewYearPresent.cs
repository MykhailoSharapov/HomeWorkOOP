// <copyright file="NewYearPresent.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NewYearPresent
    {
        private readonly Random rand;
        private Sweet[] sweets = new Sweet[] { };

        public NewYearPresent()
        {
            this.rand = new Random();
        }

        public void AddChocolateToPresent(int sweetsCount)
        {
            SugarLike choko;
            for (var i = 0; i < sweetsCount; i++)
            {
                var randParametr = this.rand.Next(1, 101);
                choko = new SugarLike($"konf:{randParametr}", randParametr, randParametr, "some shape", "vag", randParametr, DateTime.Now.AddDays(-1));
                Array.Resize<Sweet>(ref this.sweets, this.sweets.Length + 1);
                this.sweets[this.sweets.Length - 1] = choko;
            }
        }

        public void AddLolipopsToPresent(int sweetsCount)
        {
            Lolipop lolipop;
            for (var i = 0; i < sweetsCount; i++)
            {
                var randParametr = this.rand.Next(1, 101);
                lolipop = new Lolipop($"konf:{randParametr}", randParametr, randParametr, "some shape", "toyota", randParametr, "some filing");
                Array.Resize<Sweet>(ref this.sweets, this.sweets.Length + 1);
                this.sweets[this.sweets.Length - 1] = lolipop;
            }
        }

        public void AddCoockieToPresent(int sweetsCount)
        {
            CoocieChocolate coocieChoco;
            for (var i = 0; i < sweetsCount; i++)
            {
                var randParametr = this.rand.Next(1, 101);
                coocieChoco = new CoocieChocolate($"konf:{randParametr}", randParametr, randParametr, "some shape", "BMW", randParametr, DateTime.Now.AddDays(-1), "Maria");
                Array.Resize<Sweet>(ref this.sweets, this.sweets.Length + 1);
                this.sweets[this.sweets.Length - 1] = coocieChoco;
            }
        }

        public void AddZefirToPresent(int sweetsCount)
        {
            Zefir zefir;
            for (var i = 0; i < sweetsCount; i++)
            {
                var randParametr = this.rand.Next(1, 101);
                zefir = new Zefir();
                zefir.SugarContentPercent = randParametr;
                zefir.Name = $"zefir konf:{randParametr}";
                zefir.Weight = randParametr;
                Array.Resize<Sweet>(ref this.sweets, this.sweets.Length + 1);
                this.sweets[this.sweets.Length - 1] = zefir;
            }
        }

        public void GetWeightOfPresent()
        {
            var weight = 0.0;
            foreach (Sweet sweet in this.sweets)
            {
                weight += sweet.Weight;
            }

            Console.WriteLine($"Present weight: {weight}");
        }

        public void SortSweetsByWeight()
        {
            Array.Sort(this.sweets, new SweetComparer());
            this.PrintAllSweets();
        }

        public void PrintAllSweets()
        {
            foreach (Sweet sweet in this.sweets)
            {
                Console.WriteLine(this.GetDetail(sweet));
            }
        }

        public void FindSweetBySugarPercent(int sugarPercent)
        {
            var result = Array.Find<Sweet>(this.sweets, elem => elem.SugarContentPercent.Equals(sugarPercent));
            Console.WriteLine(this.GetDetail(result));
        }

        private string GetDetail(Sweet sweet)
        {
            string result = $"name: {sweet.Name}, manufacturer: {sweet.Manufacturer}, sugar percentage: {sweet.SugarContentPercent}";
            return result;
        }
    }
}
