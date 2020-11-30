// <copyright file="IDough.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace HomeWorkOOP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDough : IProduct
    {
        double FlourCount { get; set; }

        double SugarCount { get; set; }

        string AmIharmful();
    }
}
