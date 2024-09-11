using ComputerAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerAPI.Data
{
    public class ComputerDbContext : DbContext
    {
        public ComputerDbContext(DbContextOptions<ComputerDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Category> categories { get; set; }

        public DbSet<Brand> brands { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard
            var difficulties = new List<Brand>()
            {
                new Brand
                {
                    Id = Guid.Parse("54466f17-02af-48e7-8ed3-5a4a8bfacf6f"),
                    Name = "Apple",
                    Description= ""
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Brand>().HasData(difficulties);



            // Seed data for Regions
            var regions = new List<Category>
            {
                new Category
                {
                    Id = Guid.Parse("f7248fc3-2585-4efb-8d1d-1c555f4087f6"),
                    Name = "PC",
                    Description = ""
                }
            };

            modelBuilder.Entity<Category>().HasData(regions);
        }
    }
}
