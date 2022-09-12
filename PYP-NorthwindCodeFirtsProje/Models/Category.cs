using System;
using System.Collections.Generic;

namespace PYP_NorthwindCodeFirtsProje.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return $"Id:{CategoryId} CategoryName:{CategoryName}   Description:{Description}";
        }
    }
}
