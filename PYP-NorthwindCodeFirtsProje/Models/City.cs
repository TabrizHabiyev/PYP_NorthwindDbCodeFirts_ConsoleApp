using System;
using System.Collections.Generic;

namespace PYP_NorthwindCodeFirtsProje.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public string CityName { get; set; } = null!;
        public string? Code { get; set; }
        public int CountryId { get; set; }

        public virtual Country IdNavigation { get; set; } = null!;
        public virtual District District { get; set; } = null!;
        public virtual Town Town { get; set; } = null!;
    }
}
