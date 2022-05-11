using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mtmDemo.Models
{
    public class Actor
    {
        [Key]
        public int ActorId {get;set;}
        [Required]
        public string Name {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Cast> MoviesActedIn {get;set;}
    }
}