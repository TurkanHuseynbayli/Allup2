using Allup1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup1.ViewModels
{
    public class HomeVM
    {
        public ICollection<Category> Categories { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
