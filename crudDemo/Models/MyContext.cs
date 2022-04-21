using Microsoft.EntityFrameworkCore;
namespace crudDemo.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Pet> Pets { get; set; }
    }
}