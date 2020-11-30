// <copyright file="ISweet.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ISweet : IProduct
    {
        double Weight { get; set; }

        int SugarContentPercent { get; set; }

        string Shape { get; set; }
    }
}
