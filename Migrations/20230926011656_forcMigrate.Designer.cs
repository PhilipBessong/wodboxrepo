﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wodapi.Models;

#nullable disable

namespace wodapi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230926011656_forcMigrate")]
    partial class forcMigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("wodapi.Models.Exercise", b =>
                {
                    b.Property<int>("exeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("exeId"));

                    b.Property<string>("MobileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("exeId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            exeId = 1,
                            MobileUrl = "mobile/WodBox Weighted Step-up.mp4",
                            Name = "Weighted WodBox Step-ups",
                            VideoUrl = "text/41 WodBox Weighted Step-up.mp4"
                        },
                        new
                        {
                            exeId = 2,
                            MobileUrl = "mobile/WodBox Jumps.mp4",
                            Name = "WodBox Jumps",
                            VideoUrl = "text/40 WodBox Jumps.mp4"
                        },
                        new
                        {
                            exeId = 3,
                            MobileUrl = "mobile/WodBox Step Overs.mp4",
                            Name = "WodBox Step Overs",
                            VideoUrl = "text/37 WodBox Step Overs.mp4"
                        },
                        new
                        {
                            exeId = 4,
                            MobileUrl = "mobile/DB Front Rack Reverse Lunges.mp4",
                            Name = "DB Front Rack Reverse Lunges",
                            VideoUrl = "text/10 DB Front Rack Reverse Lunges.mp4"
                        },
                        new
                        {
                            exeId = 5,
                            MobileUrl = "mobile/Single Arm DB Push-Press.mp4",
                            Name = "Single Arm DB Push-Press",
                            VideoUrl = "text/9 Single Arm DB Push-Press.mp4"
                        },
                        new
                        {
                            exeId = 6,
                            MobileUrl = "mobile/DB Front Rack Squat.mp4",
                            Name = "Dumbbell Front Rack Squat",
                            VideoUrl = "text/8 DB Front Rack Squat.mp4"
                        },
                        new
                        {
                            exeId = 7,
                            MobileUrl = "mobile/High Plank Drag Across.mp4",
                            Name = "High Plank Dumbbell Drag Across",
                            VideoUrl = "text/15 High Plank DB Drag Across.mp4"
                        },
                        new
                        {
                            exeId = 8,
                            MobileUrl = "mobile/KB Single Leg Romanian Deadlift.mp4",
                            Name = "KB Single Leg Romanian Deadlift",
                            VideoUrl = "text/16 KB Single Leg Romanian Deadlift.mp4"
                        },
                        new
                        {
                            exeId = 9,
                            MobileUrl = "mobile/Russian twists with DB.mp4",
                            Name = "Russian Twists with Dumbell",
                            VideoUrl = "text/17 Russian twists with DB.mp4"
                        },
                        new
                        {
                            exeId = 10,
                            MobileUrl = "mobile/Upright KB Row.mp4",
                            Name = "Upright Kettlebell Row",
                            VideoUrl = "text/18 Upright KB Row.mp4"
                        });
                });

            modelBuilder.Entity("wodapi.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("daDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("mpr")
                        .HasColumnType("int");

                    b.Property<string>("r1m1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r1m2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r1m3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("r1move")
                        .HasColumnType("int");

                    b.Property<int>("r1rest")
                        .HasColumnType("int");

                    b.Property<int>("r1sets")
                        .HasColumnType("int");

                    b.Property<string>("r2m1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r2m2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r2m3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("r2move")
                        .HasColumnType("int");

                    b.Property<int>("r2rest")
                        .HasColumnType("int");

                    b.Property<int>("r2sets")
                        .HasColumnType("int");

                    b.Property<string>("r3m1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r3m2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r3m3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("r3move")
                        .HasColumnType("int");

                    b.Property<int>("r3rest")
                        .HasColumnType("int");

                    b.Property<int>("r3sets")
                        .HasColumnType("int");

                    b.Property<string>("r4m1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r4m2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r4m3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("r4move")
                        .HasColumnType("int");

                    b.Property<int>("r4rest")
                        .HasColumnType("int");

                    b.Property<int>("r4sets")
                        .HasColumnType("int");

                    b.Property<int>("rounds")
                        .HasColumnType("int");

                    b.Property<int>("styleId")
                        .HasColumnType("int");

                    b.Property<string>("wodCat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
