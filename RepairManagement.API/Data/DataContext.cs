using Microsoft.EntityFrameworkCore;
using RepairManagement.API.Models.Entities;

namespace RepairManagement.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> Options) : base(Options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<TypeOfService> TypeOfServices { get; set; }
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerDevice> CustomerDevices { get; set; }
    }
}
