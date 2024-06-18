namespace Task15.Models.Contexts
{
    using Microsoft.EntityFrameworkCore;
    using Task15.Models.Entities;


    
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions options)
                : base(options)
            {
            }

            public DbSet<Country> Countries { get; set; }


            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

                base.OnModelCreating(modelBuilder);
            }
        }
    }


