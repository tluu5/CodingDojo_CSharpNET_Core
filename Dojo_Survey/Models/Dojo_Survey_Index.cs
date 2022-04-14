using System;
using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey.Models
{
    public class Dojo_Survey_Index
    {
        [Required(ErrorMessage = "A name feild is required.")]
        public string Your_Name {get;set;}
        [Required(ErrorMessage = "A dojo location is required.")]
        public string Dojo_Location {get;set;}
        [Required(ErrorMessage = "A favorite language is required.")]
        public string Favorite_Language {get;set;}
        public string Comment {get;set;}
    }
}