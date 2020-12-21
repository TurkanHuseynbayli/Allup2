using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup1.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
