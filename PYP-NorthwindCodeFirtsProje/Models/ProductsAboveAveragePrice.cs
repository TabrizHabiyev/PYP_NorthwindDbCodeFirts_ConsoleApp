using System;
using System.Collections.Generic;

namespace PYP_NorthwindCodeFirtsProje.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
