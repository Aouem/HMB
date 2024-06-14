﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using clinivia_backend.Models;

#nullable disable

namespace clinivia_backend.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("clinivia_backend.Models.Departement", b =>
                {
                    b.Property<int>("D_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("D_id"));

                    b.Property<DateTime>("D_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("D_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D_head")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("D_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("D_no")
                        .HasColumnType("int");

                    b.Property<string>("D_status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("D_id");

                    b.ToTable("Departements");
                });

            modelBuilder.Entity("clinivia_backend.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("UserNom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPrenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
