using Microsoft.EntityFrameworkCore;
namespace crudDelicious.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<Dish> Dishes {get;set;}
    }
}