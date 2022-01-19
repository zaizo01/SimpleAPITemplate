﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiPractices;

namespace WebApiPractices.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220119005613_Departaments")]
    partial class Departaments
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApiPractices.Entities.Departament", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DepartamentManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartamentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantityOfEmployees")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Departaments");
                });
#pragma warning restore 612, 618
        }
    }
}
