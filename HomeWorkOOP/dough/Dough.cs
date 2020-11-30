// <copyright file="Dough.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Dough : IDough
    {
        public Dough(double flourCount, string name, double sugarCount, double cost, string manufacturer)
        {
            this.FlourCount = flourCount;
            this.Name = name;
            this.SugarCount = sugarCount;
            this.Cost = cost;
            this.Manufacturer = manufacturer;
        }

        public Dough()
        {
        }

        public double FlourCount { get; set; }

        public string Name { get; set; }

        public double SugarCount { get; set; }

        public double Cost { get; set; }

        public string Manufacturer { get; set; }

        public virtual string AmIharmful()
        {
            return "actualy no";
        }
    }
}
