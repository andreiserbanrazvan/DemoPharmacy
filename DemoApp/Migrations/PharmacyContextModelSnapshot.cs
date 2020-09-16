﻿// <auto-generated />
using System;
using DemoApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoApp.Migrations
{
    [DbContext(typeof(PharmacyContext))]
    partial class PharmacyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoApp.Models.Depot", b =>
                {
                    b.Property<int>("DepotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("DepotId");

                    b.ToTable("Depots");
                });

            modelBuilder.Entity("DemoApp.Models.Site", b =>
                {
                    b.Property<int>("SiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("MedicationUnits")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(600);

                    b.Property<string>("SiteDoctor")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("SiteNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("SiteId");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("DemoApp.Models.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("DoB")
                        .HasColumnType("DateTime2");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("SubjectNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
