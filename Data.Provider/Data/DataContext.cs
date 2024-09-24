

using Data.Contracts.User;
using Microsoft.EntityFrameworkCore;

namespace Data.Provider.Data
{
    public class DataContext : DbContext
    {
        //generate constuctor
        public DataContext(DbContextOptions options) : base(options){

        }

        public DbSet<User> Users { get; set; }
    }
}