// <copyright file="ChocolateBiscuit.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ChocolateBiscuit : Sweet
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChocolateBiscuit"/> class.
        /// </summary>
        public ChocolateBiscuit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChocolateBiscuit"/> class.
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="sugarContentPercent"></param>
        /// <param name="shape"></param>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        /// <param name="cost"></param>
        /// <param name="dough"></param>
        public ChocolateBiscuit(double weight, int sugarContentPercent, string shape, string name, string manufacturer, double cost, Dough dough)
            : base(name, weight, sugarContentPercent, shape, manufacturer, cost)
        {
            this.Dough = dough;
        }

        public Dough Dough { get; set; }
    }
}
