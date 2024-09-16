using Bakery.Models;

using Microsoft.EntityFrameworkCore;

namespace Bakery.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
                
        }

        private DbSet<Category> categories;

        public DbSet<Category> GetCategories()
        {
            return categories;
        }

        public void SetCategories(DbSet<Category> value)
        {
            categories = value;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cakes", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Pastries", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Bread", DisplayOrder = 3 }
                );
        }
    }
}
