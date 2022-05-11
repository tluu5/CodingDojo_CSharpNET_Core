using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mtmDemo.Models
{
    public class Movie
    {
        [Key]
        public int MovieId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        [Range(1895, int.MaxValue)]
        public int ReleaseYear {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Cast> ListOfActors {get;set;}
    }
}