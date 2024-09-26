using Microsoft.EntityFrameworkCore; // For DbContext, DbContextOptions, DbSet
usifbfnrnng API.Entities;//Reference the namespace where the AppUser class is located

namespace API.Data
{
    public class DataContext : DbContext
    {
        //generate constuctor
        public DataContext(DbContextOptions options) : base(options){

        }

        public DbSet<AppUser> Users { get; set; }
    }
}
