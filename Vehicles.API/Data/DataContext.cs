﻿using Microsoft.EntityFrameworkCore;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<VehicleType> VehicleTypes => Set <VehicleType> ();
        public DbSet<Procedure> Procedures => Set<Procedure>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            _ = modelBuilder.Entity<VehicleType>().HasIndex(x => x.Description).IsUnique();
            _ = modelBuilder.Entity<Procedure>().HasIndex(x => x.Description).IsUnique();
        }
    }
}
