﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cafefinder.database;

#nullable disable

namespace cafefinder.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cafefinder.database.Place", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BirthdayTheme")
                        .HasColumnType("bit");

                    b.Property<bool>("BookCafe")
                        .HasColumnType("bit");

                    b.Property<bool>("CafeShop")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FoodAndDrink")
                        .HasColumnType("bit");

                    b.Property<string>("FreeSittingTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FreeSmoke")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OpenSpace")
                        .HasColumnType("bit");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Restaurant")
                        .HasColumnType("bit");

                    b.Property<bool>("RoofGarden")
                        .HasColumnType("bit");

                    b.Property<string>("StarRating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e0421776-f722-4716-963b-9462c3534e7b"),
                            Address = "بلوار سجاد، پاساژ لاله ، انتهای پاساژ طبقه اول",
                            BirthdayTheme = false,
                            BookCafe = true,
                            CafeShop = true,
                            City = "mashhad",
                            FoodAndDrink = false,
                            FreeSittingTime = "45 min",
                            FreeSmoke = true,
                            Link = "www.mrk.co.ir",
                            LocationLink = "www.mrk.co.ir",
                            Name = "ماه من",
                            Neighborhood = "سجاد",
                            OpenSpace = true,
                            Photo = "[]",
                            Restaurant = false,
                            RoofGarden = true,
                            StarRating = "[]"
                        },
                        new
                        {
                            Id = new Guid("21a726c9-b641-4ef5-b3f4-0dfd9561c71e"),
                            Address = "بلوار سجاد ،چهارراه گلریز ، گلریز4،یاس3",
                            BirthdayTheme = false,
                            BookCafe = true,
                            CafeShop = true,
                            City = "mashhad",
                            FoodAndDrink = true,
                            FreeSittingTime = "free time",
                            FreeSmoke = true,
                            Link = "www.miranagency.ir",
                            LocationLink = "www.miranagency.ir",
                            Name = "خانه اکنون",
                            Neighborhood = "سجاد",
                            OpenSpace = true,
                            Photo = "[]",
                            Restaurant = true,
                            RoofGarden = false,
                            StarRating = "[]"
                        },
                        new
                        {
                            Id = new Guid("e5edb3aa-7b4d-484d-bf4e-a266b6cb0d01"),
                            Address = "وکیل آباد 13",
                            BirthdayTheme = false,
                            BookCafe = false,
                            CafeShop = false,
                            City = "mashhad",
                            FoodAndDrink = false,
                            FreeSittingTime = "free time",
                            FreeSmoke = false,
                            Link = "www.miranagency.ir",
                            LocationLink = "www.miranagency.ir",
                            Name = " لیالی لبنان",
                            Neighborhood = "وکیل آباد",
                            OpenSpace = true,
                            Photo = "[]",
                            Restaurant = true,
                            RoofGarden = false,
                            StarRating = "[]"
                        });
                });

            modelBuilder.Entity("cafefinder.database.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Numberphone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
