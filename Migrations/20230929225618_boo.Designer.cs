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
    [Migration("20230929225618_boo")]
    partial class boo
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

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("exeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("exeId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            exeId = 1,
                            MobileUrl = "mobile/WodBox Weighted Step-up.mp4",
                            VideoUrl = "text/41 WodBox Weighted Step-up.mp4",
                            exeName = "Weighted WodBox Step-ups"
                        },
                        new
                        {
                            exeId = 2,
                            MobileUrl = "mobile/WodBox Jumps.mp4",
                            VideoUrl = "text/40 WodBox Jumps.mp4",
                            exeName = "WodBox Jumps"
                        },
                        new
                        {
                            exeId = 3,
                            MobileUrl = "mobile/WodBox Step Overs.mp4",
                            VideoUrl = "text/37 WodBox Step Overs.mp4",
                            exeName = "WodBox Step Overs"
                        },
                        new
                        {
                            exeId = 4,
                            MobileUrl = "mobile/DB Front Rack Reverse Lunges.mp4",
                            VideoUrl = "text/10 DB Front Rack Reverse Lunges.mp4",
                            exeName = "DB Front Rack Reverse Lunges"
                        },
                        new
                        {
                            exeId = 5,
                            MobileUrl = "mobile/Single Arm DB Push-Press.mp4",
                            VideoUrl = "text/9 Single Arm DB Push-Press.mp4",
                            exeName = "Single Arm DB Push-Press"
                        },
                        new
                        {
                            exeId = 6,
                            MobileUrl = "mobile/DB Front Rack Squat.mp4",
                            VideoUrl = "text/8 DB Front Rack Squat.mp4",
                            exeName = "Dumbbell Front Rack Squat"
                        },
                        new
                        {
                            exeId = 7,
                            MobileUrl = "mobile/High Plank Drag Across.mp4",
                            VideoUrl = "text/15 High Plank DB Drag Across.mp4",
                            exeName = "High Plank Dumbbell Drag Across"
                        },
                        new
                        {
                            exeId = 8,
                            MobileUrl = "mobile/KB Single Leg Romanian Deadlift.mp4",
                            VideoUrl = "text/16 KB Single Leg Romanian Deadlift.mp4",
                            exeName = "KB Single Leg Romanian Deadlift"
                        },
                        new
                        {
                            exeId = 9,
                            MobileUrl = "mobile/Russian twists with DB.mp4",
                            VideoUrl = "text/17 Russian twists with DB.mp4",
                            exeName = "Russian Twists with Dumbell"
                        },
                        new
                        {
                            exeId = 10,
                            MobileUrl = "mobile/Upright KB Row.mp4",
                            VideoUrl = "text/18 Upright KB Row.mp4",
                            exeName = "Upright Kettlebell Row"
                        });
                });

            modelBuilder.Entity("wodapi.Models.Style", b =>
                {
                    b.Property<int>("styleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("styleId"));

                    b.Property<string>("styleDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("styleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("styleId");

                    b.ToTable("Styles");

                    b.HasData(
                        new
                        {
                            styleId = 1,
                            styleDescription = "Perform a specific movement for a duration of one minute, transition immediately to the next movement at the start of the following minute. Continue for x number of minutes.",
                            styleName = "EMOM (Every Minute On the Minute)"
                        },
                        new
                        {
                            styleId = 2,
                            styleDescription = "It consists of performing an exercise at maximum effort for 20 seconds, followed by a 10-second rest, and repeating this cycle for a total of eight rounds.",
                            styleName = "TABATA"
                        },
                        new
                        {
                            styleId = 3,
                            styleDescription = "Start with a set number of repetitions for an exercise and increase it with each round until you reach a designated endpoint.",
                            styleName = "LADDER"
                        },
                        new
                        {
                            styleId = 4,
                            styleDescription = "Alternates high-intensity exercise with rest (X number of rounds, Y amount of sec work and Z amount of rest)",
                            styleName = "INTERVAL"
                        },
                        new
                        {
                            styleId = 5,
                            styleDescription = "17-minute HIIT WOD 5 x exercises. Rotate stations, maximum reps per station. (3 rounds 5 min work. You have 1 minute rest after the first and second 5 min of work) total time 17 min",
                            styleName = "FGB (Fight gone bad)"
                        },
                        new
                        {
                            styleId = 6,
                            styleDescription = "As many rounds of specific movements as possible in X amount of time.",
                            styleName = "AMRAP (as many rounds as possible)"
                        });
                });

            modelBuilder.Entity("wodapi.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userId"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("exerciseexeId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userTypeId")
                        .HasColumnType("int");

                    b.HasKey("userId");

                    b.HasIndex("exerciseexeId");

                    b.HasIndex("userTypeId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("wodapi.Models.UserType", b =>
                {
                    b.Property<int>("userTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userTypeId"));

                    b.Property<string>("typeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userTypeId");

                    b.ToTable("UserTypes");
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

                    b.HasIndex("styleId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("wodapi.Models.User", b =>
                {
                    b.HasOne("wodapi.Models.Exercise", "exercise")
                        .WithMany()
                        .HasForeignKey("exerciseexeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wodapi.Models.UserType", "type")
                        .WithMany()
                        .HasForeignKey("userTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exercise");

                    b.Navigation("type");
                });

            modelBuilder.Entity("wodapi.Models.Workout", b =>
                {
                    b.HasOne("wodapi.Models.Style", "style")
                        .WithMany()
                        .HasForeignKey("styleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("style");
                });
#pragma warning restore 612, 618
        }
    }
}
