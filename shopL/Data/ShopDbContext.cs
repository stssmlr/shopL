using Microsoft.EntityFrameworkCore;
using shopL.Models;

namespace shopL.Data
{
    public class ShopDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopL;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(new List<Product>()
            {
                new Product() {Id= 1, Name = "Iphone 15 Pro Max", Category="Electronics", Discount=10, Price= 1099, Quantity=4},
                new Product() {Id= 2, Name = "Iphone 14 Pro Max", Category="Electronics", Discount=0, Price= 899, Quantity=0},
                new Product() {Id= 3, Name = "LG Smart TV", Category="Electronics", Discount=25, Price= 499, Quantity=4},
            });
        }

        public DbSet<Product> Products { get; set; }
    }
}
