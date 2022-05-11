using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsandCategories.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}
        [Required]
        public string Name {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> CategoryWithIn {get;set;}
    }
}