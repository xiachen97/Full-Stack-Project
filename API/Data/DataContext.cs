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