using System;
using System.ComponentModel.DataAnnotations;

namespace Exam.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get;set;}
        public int UserId {get;set;}
        public int MeetId {get;set;}
        public User Guest {get;set;}
        public Meet Meet {get;set;}
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}