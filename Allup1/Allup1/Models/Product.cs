using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Allup1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public double Discount { get; set; }
        [Required]
        public int Rate { get; set; }
        [Required]
        public int SaleCount { get; set; }
        [Required]
        public int Count { get; set; }
        public double Extax { get; set; }
        public string Brand { get; set; }
        public string Tags { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
