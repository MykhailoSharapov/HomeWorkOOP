using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class NewYearPresent
    {
        private Sweet[] sweets = new Sweet[] { };
        private readonly Random rand;
        public NewYearPresent()
        {
            rand = new Random();
        }
        public void AddChocolateToPresent(int SweetsCount)
        {
            SugarLike choko;
            for (var i = 0; i < SweetsCount; i++)
            {
                var randParametr = rand.Next(1, 101);
                choko = new SugarLike($"konf:{randParametr}", randParametr, randParametr, "some shape", "vag", randParametr, DateTime.Now.AddDays(-1));
                Array.Resize<Sweet>(ref sweets, sweets.Length + 1);
                sweets[sweets.Length - 1] = choko;
            }
        }
        public void AddLolipopsToPresent(int SweetsCount)
        {
            Lolipop lolipop;
            for (var i = 0; i < SweetsCount; i++)
            {
                var randParametr = rand.Next(1, 101);
                lolipop = new Lolipop($"konf:{randParametr}", randParametr, randParametr, "some shape", "toyota", randParametr, "some filing");
                Array.Resize<Sweet>(ref sweets, sweets.Length + 1);
                sweets[sweets.Length - 1] = lolipop;
            }
        }
        public void AddCoockieToPresent(int SweetsCount)
        {
            CoocieChocolate coocieChoco;
            for (var i = 0; i < SweetsCount; i++)
            {
                var randParametr = rand.Next(1, 101);
                coocieChoco = new CoocieChocolate($"konf:{randParametr}", randParametr, randParametr, "some shape", "BMW", randParametr, DateTime.Now.AddDays(-1), "Maria");
                Array.Resize<Sweet>(ref sweets, sweets.Length + 1);
                sweets[sweets.Length - 1] = coocieChoco;
            }
        }
        public void GetWeightOfPresent()
        {
            var weight = 0.0;
            foreach (Sweet sweet in sweets)
            {
                weight += sweet.Weight;
            }
            Console.WriteLine($"Present weight: {weight}");
        }
        public void SortSweetsByWeight()
        {
            Array.Sort(sweets, new SweetComparer());
            PrintAllSweets();
        }
        public void PrintAllSweets()
        {
            foreach (Sweet sweet in sweets)
            {
                Console.WriteLine(GetDetail(sweet));
            }
        }
        private string GetDetail(Sweet sweet)
        {
            string result = $"name: {sweet.Name}, manufacturer: {sweet.Manufacturer}, sugar percentage: {sweet.SugarContentPercent}";
            return result;
        }
        public void FindSweetBySugarPercent(int sugarPercent)
        {
            var result = Array.Find<Sweet>(sweets, elem => elem.SugarContentPercent.Equals(sugarPercent));
            Console.WriteLine(GetDetail(result));
        }
    }
}
