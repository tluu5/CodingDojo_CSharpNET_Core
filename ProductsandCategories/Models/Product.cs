using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsandCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Description {get;set;}
        [Required]
        [Range(1, int.MaxValue)]
        public decimal Price {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> ProductWithIn {get;set;}
    }
}