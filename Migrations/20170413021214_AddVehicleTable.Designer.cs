using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Vega.Data;

namespace Vega.Migrations
{
    [DbContext(typeof(VegaDbContext))]
    [Migration("20170413021214_AddVehicleTable")]
    partial class AddVehicleTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Vega.Data.Models.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Vega.Data.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("Vega.Data.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MakeId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("Vega.Data.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactEmail");

                    b.Property<string>("ContactName");

                    b.Property<string>("ContactPhone");

                    b.Property<bool>("IsRegistered");

                    b.Property<int>("MakeId");

                    b.Property<int>("ModelId");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.HasIndex("ModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Vega.Data.Models.VehicleFeature", b =>
                {
                    b.Property<int>("VehicleId");

                    b.Property<int>("FeatureId");

                    b.HasKey("VehicleId", "FeatureId");

                    b.HasIndex("FeatureId");

                    b.ToTable("VehicleFeatures");
                });

            modelBuilder.Entity("Vega.Data.Models.Model", b =>
                {
                    b.HasOne("Vega.Data.Models.Make", "Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Vega.Data.Models.Vehicle", b =>
                {
                    b.HasOne("Vega.Data.Models.Make", "Make")
                        .WithMany()
                        .HasForeignKey("MakeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Vega.Data.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId");
                });

            modelBuilder.Entity("Vega.Data.Models.VehicleFeature", b =>
                {
                    b.HasOne("Vega.Data.Models.Feature", "Feature")
                        .WithMany()
                        .HasForeignKey("FeatureId");

                    b.HasOne("Vega.Data.Models.Vehicle", "Vehicle")
                        .WithMany("VehicleFeatures")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
