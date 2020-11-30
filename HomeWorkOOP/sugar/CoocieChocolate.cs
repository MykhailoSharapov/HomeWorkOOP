// <copyright file="CoocieChocolate.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CoocieChocolate : SugarLike
    {
        public CoocieChocolate(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, DateTime expiration, string coockieType)
            : base(name, weight, sugarContentPercent, shape, manufacturer, cost, expiration)
        {
            this.CoockieType = coockieType;
        }

        public string CoockieType { get; private set; }

        public override string MyUniqeName()
        {
            return "third name";
        }
    }
}
