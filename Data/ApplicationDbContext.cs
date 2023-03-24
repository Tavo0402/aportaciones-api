using Aportaciones.Data.Configuration;
using Aportaciones.Models;
using Microsoft.EntityFrameworkCore;

namespace Aportaciones.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Input> Inputs { get; set; }
        public DbSet<InputDetails> Details { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InputConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
        }
    }
}
