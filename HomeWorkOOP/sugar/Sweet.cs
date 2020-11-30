// <copyright file="Sweet.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Sweet : ISweet
    {
        public Sweet()
        {
        }

        public Sweet(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost)
        {
            this.Name = name;
            this.Weight = weight;
            this.SugarContentPercent = sugarContentPercent;
            this.Shape = shape;
            this.Manufacturer = manufacturer;
            this.Cost = cost;
        }

        public double Weight { get; set; }

        public int SugarContentPercent { get; set; }

        public string Shape { get; set; }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public double Cost { get; set; }

        public virtual bool IsCarriesCaller()
        {
            return true;
        }

        public virtual string MyUniqeName()
        {
            return "fisrt name for cream and lolipos";
        }
    }
}
