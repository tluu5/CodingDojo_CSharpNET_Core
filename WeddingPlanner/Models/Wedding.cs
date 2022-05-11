using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WeddingPlanner.Models
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get;set;}
        [Required]
        public string WeddingOne {get;set;}
        [Required]
        public string WeddingTwo {get;set;}
        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "4/26/2022", "1/1/3000")]
        public DateTime WeddingDate {get;set;}
        [Required]
        public string WeddingAddress {get;set;}
        public int UserId {get;set;}
        public User Bride {get;set;}
        public List<Order> GuestsList {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}