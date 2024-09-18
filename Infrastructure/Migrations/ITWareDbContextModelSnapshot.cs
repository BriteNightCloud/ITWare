﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ITWareDbContext))]
    partial class ITWareDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("ApplicationCore.Models.Equipment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BarCode")
                        .HasColumnType("TEXT");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Count")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<long?>("LocationId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NetworkName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SNL")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LocationId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("ApplicationCore.Models.EquipmentCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EquipmentCategory");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.InUseLocation.Area", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("BuildingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.InUseLocation.Building", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Building");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasDiscriminator().HasValue("Location");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.StoredLocation.Rack", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Rack");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.StoredLocation.Shelf", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BarCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("RackId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RackId");

                    b.ToTable("Shelf");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.InUseLocation.InUseLocation", b =>
                {
                    b.HasBaseType("ApplicationCore.Models.Location.Location");

                    b.Property<long>("AreaId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("BuildingId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("AreaId");

                    b.HasIndex("BuildingId");

                    b.HasDiscriminator().HasValue("InUseLocation");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.StoredLocation.StoredLocation", b =>
                {
                    b.HasBaseType("ApplicationCore.Models.Location.Location");

                    b.Property<long>("RackId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ShelfId")
                        .HasColumnType("INTEGER");

                    b.HasIndex("RackId");

                    b.HasIndex("ShelfId");

                    b.HasDiscriminator().HasValue("StoredLocation");
                });

            modelBuilder.Entity("ApplicationCore.Models.Equipment", b =>
                {
                    b.HasOne("ApplicationCore.Models.EquipmentCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Models.Location.Location", "Location")
                        .WithMany("Equipment")
                        .HasForeignKey("LocationId");

                    b.Navigation("Category");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.InUseLocation.Area", b =>
                {
                    b.HasOne("ApplicationCore.Models.Location.InUseLocation.Building", "Building")
                        .WithMany("Areas")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.StoredLocation.Shelf", b =>
                {
                    b.HasOne("ApplicationCore.Models.Location.StoredLocation.Rack", "Rack")
                        .WithMany("Shelves")
                        .HasForeignKey("RackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rack");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.InUseLocation.InUseLocation", b =>
                {
                    b.HasOne("ApplicationCore.Models.Location.InUseLocation.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Models.Location.InUseLocation.Building", "Building")
                        .WithMany()
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Building");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.StoredLocation.StoredLocation", b =>
                {
                    b.HasOne("ApplicationCore.Models.Location.StoredLocation.Rack", "Rack")
                        .WithMany()
                        .HasForeignKey("RackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Models.Location.StoredLocation.Shelf", "Shelf")
                        .WithMany()
                        .HasForeignKey("ShelfId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rack");

                    b.Navigation("Shelf");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.InUseLocation.Building", b =>
                {
                    b.Navigation("Areas");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.Location", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("ApplicationCore.Models.Location.StoredLocation.Rack", b =>
                {
                    b.Navigation("Shelves");
                });
#pragma warning restore 612, 618
        }
    }
}
