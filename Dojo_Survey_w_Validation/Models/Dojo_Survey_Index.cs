using System;
using System.ComponentModel.DataAnnotations;

namespace Dojo_Survey.Models
{
    public class Dojo_Survey_Index
    {
        [Required(ErrorMessage = "A name feild is required.")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters in length!")]
        public string Your_Name {get;set;}
        [Required(ErrorMessage = "A dojo location is required.")]
        public string Dojo_Location {get;set;}
        [Required(ErrorMessage = "A favorite language is required.")]
        public string Favorite_Language {get;set;}
        [MinLength(20, ErrorMessage = "Comment exceeded 20 characters in length!")]
        public string Comment {get;set;}
    }
}