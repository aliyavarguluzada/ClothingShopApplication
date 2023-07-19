using ClothingShopApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CategoryGender> CategoryGenders { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }   
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }    
        public DbSet<Size> Sizes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-9RG21DM\\SQLEXPRESS;" +
                "Initial Catalog = ClothingShopDb;" +
                "Integrated Security = true;" +
                "TrustServerCertificate = true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryGender>()
                .Property(x => x.Gender)
                .IsRequired();

        }
    }
}
