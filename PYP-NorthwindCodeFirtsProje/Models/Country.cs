using System;
using System.Collections.Generic;

namespace PYP_NorthwindCodeFirtsProje.Models
{
    public partial class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; } = null!;
        public string? Code { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual District District { get; set; } = null!;
        public virtual Town Town { get; set; } = null!;
    }
}
