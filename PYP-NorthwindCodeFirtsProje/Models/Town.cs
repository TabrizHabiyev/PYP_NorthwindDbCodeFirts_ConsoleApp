using System;
using System.Collections.Generic;

namespace PYP_NorthwindCodeFirtsProje.Models
{
    public partial class Town
    {
        public int Id { get; set; }
        public string TownName { get; set; } = null!;
        public string? Code { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }

        public virtual Country Id1 { get; set; } = null!;
        public virtual District Id2 { get; set; } = null!;
        public virtual City IdNavigation { get; set; } = null!;
    }
}
