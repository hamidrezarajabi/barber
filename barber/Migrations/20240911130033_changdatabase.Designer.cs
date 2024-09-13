﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cafefinder.database;

#nullable disable

namespace cafefinder.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240911130033_changdatabase")]
    partial class changdatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<bool>("Childeren")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DamadArosGrim")
                        .HasColumnType("bit");

                    b.Property<string>("LocationLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Man")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Neighborhood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PaksaziSorat")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StarRating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Women")
                        .HasColumnType("bit");

                    b.Property<string>("WorkTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("feshial")
                        .HasColumnType("bit");

                    b.Property<bool>("kashtnakhon")
                        .HasColumnType("bit");

                    b.Property<bool>("keratin")
                        .HasColumnType("bit");

                    b.Property<string>("rezerv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("selectrezerv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e45488a-204f-4058-9254-68ddc29c9e9f"),
                            Address = "بلوار سجاد ، گلریز 1",
                            Childeren = false,
                            City = "mashhad",
                            DamadArosGrim = true,
                            LocationLink = "https://www.mrk.co.ir",
                            Man = false,
                            Name = "سالن زیبایی آنارام",
                            Neighborhood = "سجاد",
                            PaksaziSorat = true,
                            Password = "Password",
                            Photo = "[]",
                            StarRating = "[]",
                            UserName = "anaram",
                            Women = true,
                            WorkTime = "ساعت 10 الی 22",
                            feshial = true,
                            kashtnakhon = true,
                            keratin = true,
                            rezerv = "[]",
                            selectrezerv = "{}"
                        },
                        new
                        {
                            Id = new Guid("dcbed773-1bd0-4964-ba1f-ca487b5f145d"),
                            Address = "بلوار سجاد ، بزرگمهر جنوبی 3",
                            Childeren = false,
                            City = "mashhad",
                            DamadArosGrim = true,
                            LocationLink = "https://www.mrk.co.ir",
                            Man = true,
                            Name = "آرایشگاه مردانه کامران",
                            Neighborhood = "ملک آباد",
                            PaksaziSorat = true,
                            Password = "Password",
                            Photo = "[]",
                            StarRating = "[]",
                            UserName = "kamran-sajad",
                            Women = false,
                            WorkTime = "ساعت 8 الی 20",
                            feshial = false,
                            kashtnakhon = false,
                            keratin = true,
                            rezerv = "[]",
                            selectrezerv = "{}"
                        },
                        new
                        {
                            Id = new Guid("adc16299-ce5d-4dbd-9d62-bfd710c1dc36"),
                            Address = "بلوار سجاد ، حامد شمالی 5 ",
                            Childeren = false,
                            City = "mashhad",
                            DamadArosGrim = false,
                            LocationLink = "https://www.mrk.co.ir",
                            Man = false,
                            Name = "سالن زیبایی ماه مریم",
                            Neighborhood = "حامد شمالی",
                            PaksaziSorat = true,
                            Password = "Password",
                            Photo = "[]",
                            StarRating = "[]",
                            UserName = "maryam-moon",
                            Women = true,
                            WorkTime = "ساعت 8 الی 23",
                            feshial = true,
                            kashtnakhon = false,
                            keratin = true,
                            rezerv = "[]",
                            selectrezerv = "{}"
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("d54b6a68-d0e4-4490-8c13-9607852c8b25"),
                            Numberphone = "09334101438",
                            Password = "cafe1403admin*",
                            UserName = "admin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
