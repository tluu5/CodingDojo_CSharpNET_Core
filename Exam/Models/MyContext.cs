using Microsoft.EntityFrameworkCore;
namespace Exam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get;set;}
        public DbSet<Meet> Meets {get;set;}
        public DbSet<Order> Orders {get;set;}
    }
}