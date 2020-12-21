using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Allup1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        public bool IsMain { get; set; }
        public bool IsDeleted { get; set; }
        public Category Parent { get; set; }
        public ICollection<Category> Children { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
