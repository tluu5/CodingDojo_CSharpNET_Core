using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email {get;set;}
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
        [NotMapped]
        [Compare("Password", ErrorMessage = "Password must match Confirm Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        public List<Wedding> WeddingsPlan {get;set;}
        public List<Order> WeddingsAttend {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}