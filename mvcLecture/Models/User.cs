using System;
using System.ComponentModel.DataAnnotations;

namespace mvcLecture.Models
{
    public class User
    {
        [Required(ErrorMessage = "You gotta have a name")]
        public string Name {get;set;}
        [Required]
        [MinLength(3, ErrorMessage = "Color must be at least 3 characters in length!")]
        public string FavColor {get;set;}
        [Range(-2000, 2000)]
        public int FavNumber {get;set;}
    }
}