using Microsoft.EntityFrameworkCore;
using App.Data.Entities;
using System;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "Admin", CreatedAt = DateTime.Now },
                new Role { Id = 2, Name = "Seller", CreatedAt = DateTime.Now },
                new Role { Id = 3, Name = "Buyer", CreatedAt = DateTime.Now }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Admin",
                    LastName = "User",
                    Email = "admin@ecommerce.com",
                    Password = "password",
                    RoleId = 1,
                    CreatedAt = DateTime.Now,
                    Enabled = true
                }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Vegetables", Color = "Green", IconCssClass = "icon-veg", CreatedAt = DateTime.Now },
                new Category { Id = 2, Name = "Fruits", Color = "Yellow", IconCssClass = "icon-fruit", CreatedAt = DateTime.Now },
                new Category { Id = 3, Name = "Meat", Color = "Red", IconCssClass = "icon-meat", CreatedAt = DateTime.Now },
                new Category { Id = 4, Name = "Dairy", Color = "Blue", IconCssClass = "icon-dairy", CreatedAt = DateTime.Now },
                new Category { Id = 5, Name = "Seafood", Color = "Aqua", IconCssClass = "icon-seafood", CreatedAt = DateTime.Now },
                new Category { Id = 6, Name = "Grains", Color = "Brown", IconCssClass = "icon-grains", CreatedAt = DateTime.Now },
                new Category { Id = 7, Name = "Beverages", Color = "Orange", IconCssClass = "icon-beverage", CreatedAt = DateTime.Now },
                new Category { Id = 8, Name = "Snacks", Color = "Pink", IconCssClass = "icon-snack", CreatedAt = DateTime.Now },
                new Category { Id = 9, Name = "Frozen Foods", Color = "Purple", IconCssClass = "icon-frozen", CreatedAt = DateTime.Now },
                new Category { Id = 10, Name = "Bakery", Color = "Gold", IconCssClass = "icon-bakery", CreatedAt = DateTime.Now }
            );
        }
    }
}
