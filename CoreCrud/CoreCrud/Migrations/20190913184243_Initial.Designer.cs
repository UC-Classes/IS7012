﻿// <auto-generated />
using System;
using CoreCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreCrud.Migrations
{
    [DbContext(typeof(CoreCrudContext))]
    [Migration("20190913184243_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreCrud.Models.Destination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Budget");

                    b.Property<string>("DiveSites");

                    b.Property<DateTime>("LeaveDate");

                    b.Property<string>("Location");

                    b.Property<string>("NationalParks");

                    b.Property<DateTime>("ReturnDate");

                    b.HasKey("ID");

                    b.ToTable("Destination");
                });
#pragma warning restore 612, 618
        }
    }
}
