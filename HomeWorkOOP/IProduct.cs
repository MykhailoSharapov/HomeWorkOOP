// <copyright file="IProduct.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IProduct
    {
        double Cost { get; set; }

        string Name { get; set; }

        string Manufacturer { get; set; }
    }
}
