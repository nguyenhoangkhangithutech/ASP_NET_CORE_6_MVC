using Microsoft.EntityFrameworkCore;

namespace aspnetcore6_tutorial.Data
{
    public class DbApp : DbContext
    {

        public DbApp(DbContextOptions options) : base(options) { }

        public DbSet<Account> accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(e =>
            {
                e.ToTable("Account");
                e.HasKey(e => e.Id);

            });
        }
    }
}
