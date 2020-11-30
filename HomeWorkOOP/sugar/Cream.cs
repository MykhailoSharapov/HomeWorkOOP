// <copyright file="Cream.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Cream : SugarLike
    {
        public Cream(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, DateTime expiration, string butter)
            : base(name, weight, sugarContentPercent, shape, manufacturer, cost, expiration)
        {
            this.Butter = butter;
        }

        public Cream()
        {
        }

        public string Butter { get; private set; }
    }
}
