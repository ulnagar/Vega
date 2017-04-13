using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Vega.Data.Models;

namespace Vega.Data
{
    public class VegaDbContext : DbContext
    {

        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {   
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleFeature> VehicleFeatures { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<VehicleFeature>()
                .HasKey(vf =>
                    new {vf.VehicleId, vf.FeatureId}
                );

            mb.Entity<VehicleFeature>()
                .HasOne(vf => vf.Feature)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Vehicle>()
                .HasOne(v => v.Model)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
