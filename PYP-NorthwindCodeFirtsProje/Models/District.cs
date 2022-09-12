using System;
using System.Collections.Generic;

namespace PYP_NorthwindCodeFirtsProje.Models
{
    public partial class District
    {
        public int Id { get; set; }
        public string DistrictName { get; set; } = null!;
        public string? Code { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }

        public virtual Country Id1 { get; set; } = null!;
        public virtual City IdNavigation { get; set; } = null!;
        public virtual Town Town { get; set; } = null!;
    }
}
