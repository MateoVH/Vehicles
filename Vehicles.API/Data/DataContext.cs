using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<VehicleType> VehicleTypes => Set <VehicleType> ();
        public DbSet<Procedure> Procedures => Set<Procedure>();
        public DbSet<DocumentType> DocumentTypes => Set<DocumentType>();
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Detail> Details => Set<Detail>();
        public DbSet<History> Histories => Set<History>();
        public DbSet<VehiclePhoto> VehiclePhotos => Set<VehiclePhoto>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
            _ = modelBuilder.Entity<Procedure>().HasIndex(x => x.Description).IsUnique();
            _ = modelBuilder.Entity<DocumentType>().HasIndex(x => x.Description).IsUnique();
            _ = modelBuilder.Entity<Brand>().HasIndex(x => x.Description).IsUnique();
            _ = modelBuilder.Entity<Vehicle>().HasIndex(x => x.Plaque).IsUnique();
        }
    }
}
