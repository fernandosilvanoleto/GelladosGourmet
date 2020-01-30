﻿// <auto-generated />
using System;
using GelladosGourmet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GelladosGourmet.Migrations
{
    [DbContext(typeof(GelladosGourmetContext))]
    partial class GelladosGourmetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GelladosGourmet.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("GelladosGourmet.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("GelladosGourmet.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("GelladosGourmet.Models.SalesRecord", b =>
                {
                    b.HasOne("GelladosGourmet.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("GelladosGourmet.Models.Seller", b =>
                {
                    b.HasOne("GelladosGourmet.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
