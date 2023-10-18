using Microsoft.EntityFrameworkCore;
using TravelAgentApp.Models;

namespace TravelAgentApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public DbSet<CategoryMapping> CategoryMappings { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Inventory> Inventories{ get; set; }
        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant>().HasData(
                new Merchant { Id = 1, Name = "Sindo Ferry", Email = "sindoferry@gmail.com", Phone = "+65 6331 4123", Username = "sindoferry", Password = "12345678", 
                    Address = "1 Maritime Square HarbourFront Centre", CreatedOn =  DateTime.Now}
                );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { Id = 1, Name = "Hotel Room"},
                new ProductCategory { Id = 2, Name = "Ferry Ticket"},
                new ProductCategory { Id = 3, Name = "Plane Ticket"}
                );

            modelBuilder.Entity<ProductSubCategory>().HasData(
                new ProductSubCategory { Id = 1, Name = "Superior Room"},
                new ProductSubCategory { Id = 2, Name = "Deluxe Room"},
                new ProductSubCategory { Id = 3, Name = "Suite Room"},
                new ProductSubCategory { Id = 4, Name = "Economy Class"},
                new ProductSubCategory { Id = 5, Name = "VIP Class"},
                new ProductSubCategory { Id = 6, Name = "Business Class"},
                new ProductSubCategory { Id = 7, Name = "First Class"}
                );

            modelBuilder.Entity<CategoryMapping>().HasData(
                new CategoryMapping { Id = 1, CategoryId = 1, SubCategoryId = 1},
                new CategoryMapping { Id = 2, CategoryId = 1, SubCategoryId = 2},
                new CategoryMapping { Id = 3, CategoryId = 1, SubCategoryId = 3},
                new CategoryMapping { Id = 4, CategoryId = 2, SubCategoryId = 4},
                new CategoryMapping { Id = 5, CategoryId = 2, SubCategoryId = 5},
                new CategoryMapping { Id = 6, CategoryId = 3, SubCategoryId = 4},
                new CategoryMapping { Id = 7, CategoryId = 3, SubCategoryId = 6},
                new CategoryMapping { Id = 8, CategoryId = 3, SubCategoryId = 7}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "1WBTC-TMFT", CategoryMappingId = 4, MerchantId = 1, Price = 400000, 
                    Description = "Single (1-way) Batam Centre to Tanah Merah Ferry Terminal", CreatedBy = "sindoferry", CreatedOn = DateTime.Now}
                );

            modelBuilder.Entity<Inventory>().HasData(
                new Inventory { Id = 1, InventoryNo = "INV00001", ProductId = 1, Qty = 1, StartValidDate = DateTime.Today, 
                    EndValidDate = DateTime.Today.AddDays(1), UpdatedBy = ""}
                );

            //modelBuilder.Entity<Customer>().HasData(
            //    new Customer { Id = 1, FullName = "Meiliverani Erline", Email = "meiliverani@gmail.com", Phone = "082386669859", BirthDate = new DateTime(2000, 05, 14), Username = "meilivrn", Password = "12345678", Address = "Dumai", CreatedOn = DateTime.Now }
            //    );
        }
    }
}
