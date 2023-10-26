using Entities;
using Microsoft.EntityFrameworkCore;
using NetCoreWebApplication.DataSeed;

namespace NetCoreWebApplication.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Server=(localDb)\MSSQLLocalDb;Database=NetCoreWebApplication; Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PostSeedData());
            modelBuilder.ApplyConfiguration(new ContactSeedData());
            modelBuilder.ApplyConfiguration(new CategorySeedData());
            modelBuilder.ApplyConfiguration(new NewSeedData());
            modelBuilder.ApplyConfiguration(new SliderSeedData());
            modelBuilder.ApplyConfiguration(new UserSeedData());

        }
    }
}