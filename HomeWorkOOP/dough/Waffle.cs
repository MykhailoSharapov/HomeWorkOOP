// <copyright file="Waffle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Waffle : Dough
    {
        public Waffle()
        {
        }

        public Waffle(double flourCount, string name, double sugarCount, double cost, string manufacturer, string syropName)
            : base(flourCount, name, sugarCount, cost, manufacturer)
        {
            this.SyropName = syropName;
        }

        public string SyropName { get; set; }

        public override string AmIharmful()
        {
            return "No, but ne yvlekysa";
        }
    }
}
