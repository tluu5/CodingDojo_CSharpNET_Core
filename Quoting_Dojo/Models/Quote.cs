using System;

using System.ComponentModel.DataAnnotations;



namespace QuotingDojo.Models

{

    public class Quote

    {

        [Required]

        [Display(Name = "Name:")]

        public string Content { get; set; }

        [Required]

        [Display(Name = "Quote:")]

        public string Byline { get; set; }

    }

}