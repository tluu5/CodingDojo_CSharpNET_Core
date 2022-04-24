using System;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public int Tastiness {get;set;}
        [Required]
        [Range(0, Int32.MaxValue)]
        public int Calories {get;set;}
        [Required]
        public string Description {get;set;}
        public int ChefId {get;set;}
        public Chef Worker {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}