using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Meet
    {
        [Key]
        public int MeetId {get;set;}
        public int UserId {get;set;}
        [Required]
        public string Title {get;set;}
        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "4/27/2022", "1/1/3000")]
        public DateTime DateNTime {get;set;}
        public int Hours {get;set;}
        public int Minutes {get;set;}
        public int Days {get;set;}
        [Required]
        public string Description {get;set;}
        public User Creator {get;set;}
        public List<Order> GuestsList {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}