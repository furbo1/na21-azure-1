using System;
using System.Collections.Generic;

#nullable disable

namespace DatabaseFirstExample.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
