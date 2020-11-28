﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP
{
    public class CoocieChocolate : Chokolate
    {
        public CoocieChocolate(string name, double weight, int sugarContentPercent, string shape, string manufacturer, double cost, DateTime expiration, string coockieType) : base(name, weight, sugarContentPercent, shape, manufacturer, cost,expiration)
        {
            CoockieType = coockieType;
        }
        public string CoockieType { get; private set; }
    }
}
