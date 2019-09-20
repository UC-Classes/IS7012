﻿// <auto-generated />
using System;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCrud.Migrations
{
    [DbContext(typeof(CoreCrudContext))]
    partial class CoreCrudContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCrud.Models.Country", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName");

                    b.HasKey("ID");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("CoreCrud.Models.Destination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget");

                    b.Property<string>("DiveSites");

                    b.Property<DateTime>("LeaveDate");

                    b.Property<int>("LocationID");

                    b.Property<string>("NationalParks");

                    b.Property<DateTime>("ReturnDate");

                    b.Property<string>("TripName");

                    b.HasKey("ID");

                    b.HasIndex("LocationID");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("CoreCrud.Models.Destination", b =>
                {
                    b.HasOne("CoreCrud.Models.Country", "Location")
                        .WithMany("destinations")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
