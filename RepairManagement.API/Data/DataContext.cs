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







    }
}
