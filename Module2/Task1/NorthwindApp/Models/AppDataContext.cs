using Microsoft.EntityFrameworkCore;
using NorthwindApp.ViewModels;

namespace NorthwindApp.Models
{
    public class AppDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        public DbSet<NorthwindApp.ViewModels.ProductViewModel> ProductViewModel { get; set; }
    }
}
