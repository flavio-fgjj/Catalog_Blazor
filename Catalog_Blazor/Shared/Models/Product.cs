using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Blazor.Shared.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? ImageUrl { get; set; }

        // indicate the relationship 
        public int CategoryId { get; set; }
        // navigation prop
        public virtual Category? Category { get; set; }
    }
}
