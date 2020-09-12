﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200910174448_SeedSeminars")]
    partial class SeedSeminars
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Seminar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seminars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "101 Main St",
                            City = "Gothenburg",
                            DateTime = new DateTime(2020, 9, 10, 19, 44, 47, 905, DateTimeKind.Local).AddTicks(1978),
                            Name = "Seminar 101"
                        },
                        new
                        {
                            Id = 2,
                            Address = "101 Main St",
                            City = "Gothenburg",
                            DateTime = new DateTime(2020, 9, 10, 19, 44, 47, 915, DateTimeKind.Local).AddTicks(3252),
                            Name = "Seminar 102"
                        },
                        new
                        {
                            Id = 3,
                            Address = "101 Main St",
                            City = "Gothenburg",
                            DateTime = new DateTime(2020, 9, 10, 19, 44, 47, 915, DateTimeKind.Local).AddTicks(3329),
                            Name = "Seminar 103"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}