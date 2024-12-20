﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MountainTrainingApp.Data;

#nullable disable

namespace MountainTrainingApp.Data.Migrations
{
    [DbContext(typeof(MountainTrainigAppDbContext))]
    partial class MountainTrainigAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.AerobicActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("AerobicActivities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Trail running"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Hiking"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Mountain biking"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Road biking"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Road running"
                        },
                        new
                        {
                            Id = 6,
                            IsDeleted = false,
                            Name = "Cross-country skiing"
                        },
                        new
                        {
                            Id = 7,
                            IsDeleted = false,
                            Name = "Swimming"
                        });
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.AerobicWorkout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AddedWeight")
                        .HasColumnType("float");

                    b.Property<int>("AerobicActivityId")
                        .HasColumnType("int");

                    b.Property<Guid>("AthletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AverageHeartRate")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<int>("BurnedCalories")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayOfWeekId")
                        .HasColumnType("int");

                    b.Property<double>("Distance")
                        .HasColumnType("float");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<int>("ElevationGain")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrainingPeriodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AerobicActivityId");

                    b.HasIndex("AthletId");

                    b.HasIndex("DayOfWeekId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("TrainingPeriodId");

                    b.ToTable("AerobicWorkouts");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.Climbing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AthletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClimbingActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayOfWeekId")
                        .HasColumnType("int");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("RopesClimbed")
                        .HasColumnType("int");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrainingPeriodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AthletId");

                    b.HasIndex("ClimbingActivityId");

                    b.HasIndex("DayOfWeekId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("TrainingPeriodId");

                    b.ToTable("Climbings");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.ClimbingActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ClimbingActivities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Sport rock climbing"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Trad rock climbing"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Ice climbing"
                        },
                        new
                        {
                            Id = 4,
                            IsDeleted = false,
                            Name = "Mixed climbing"
                        },
                        new
                        {
                            Id = 5,
                            IsDeleted = false,
                            Name = "Alpine climbing"
                        });
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.DayOfWeek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Id");

                    b.ToTable("DaysOfWeek");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Monday"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tuesday"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wednesday"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Thursday"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Friday"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Saturday"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Sunday"
                        });
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.StrengthWorkout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AddedWeightLegs")
                        .HasColumnType("float");

                    b.Property<double>("AddedWeightUpperBody")
                        .HasColumnType("float");

                    b.Property<Guid>("AthletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateAndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayOfWeekId")
                        .HasColumnType("int");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Repetitions")
                        .HasMaxLength(2147483647)
                        .HasColumnType("int");

                    b.Property<int>("StrengthWorkoutTypeId")
                        .HasColumnType("int");

                    b.Property<Guid?>("TrainerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TrainingPeriodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AthletId");

                    b.HasIndex("DayOfWeekId");

                    b.HasIndex("StrengthWorkoutTypeId");

                    b.HasIndex("TrainerId");

                    b.HasIndex("TrainingPeriodId");

                    b.ToTable("StrengthWorkouts");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.StrengthWorkoutType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("StrengthWorkoutTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "General strength"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Max strength"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Muscle endurance"
                        });
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.Trainer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("IMFGALicenseNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.TrainingPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TrainingPeriods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Transition"
                        },
                        new
                        {
                            Id = 2,
                            IsDeleted = false,
                            Name = "Base"
                        },
                        new
                        {
                            Id = 3,
                            IsDeleted = false,
                            Name = "Specific"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.AerobicWorkout", b =>
                {
                    b.HasOne("MountainTrainingApp.Data.Models.AerobicActivity", "AerobicActivity")
                        .WithMany("AerobicWorkouts")
                        .HasForeignKey("AerobicActivityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", "Athlet")
                        .WithMany("AerobicWorkouts")
                        .HasForeignKey("AthletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.DayOfWeek", "DayOfWeek")
                        .WithMany("AerobicWorkouts")
                        .HasForeignKey("DayOfWeekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.Trainer", "Trainer")
                        .WithMany("AerobicWorkouts")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MountainTrainingApp.Data.Models.TrainingPeriod", "TrainingPeriod")
                        .WithMany("AerobicWorkouts")
                        .HasForeignKey("TrainingPeriodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AerobicActivity");

                    b.Navigation("Athlet");

                    b.Navigation("DayOfWeek");

                    b.Navigation("Trainer");

                    b.Navigation("TrainingPeriod");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.Climbing", b =>
                {
                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", "Athlet")
                        .WithMany("Climbings")
                        .HasForeignKey("AthletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.ClimbingActivity", "ClimbingActivity")
                        .WithMany("Climbings")
                        .HasForeignKey("ClimbingActivityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.DayOfWeek", "DayOfWeek")
                        .WithMany("Climbings")
                        .HasForeignKey("DayOfWeekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.Trainer", "Trainer")
                        .WithMany("Climbings")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MountainTrainingApp.Data.Models.TrainingPeriod", "TrainingPeriod")
                        .WithMany("Climbings")
                        .HasForeignKey("TrainingPeriodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Athlet");

                    b.Navigation("ClimbingActivity");

                    b.Navigation("DayOfWeek");

                    b.Navigation("Trainer");

                    b.Navigation("TrainingPeriod");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.StrengthWorkout", b =>
                {
                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", "Athlet")
                        .WithMany("StrengthWorkouts")
                        .HasForeignKey("AthletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.DayOfWeek", "DayOfWeek")
                        .WithMany("StrengthWorkouts")
                        .HasForeignKey("DayOfWeekId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.StrengthWorkoutType", "StrengthWorkoutType")
                        .WithMany("StrengthWorkouts")
                        .HasForeignKey("StrengthWorkoutTypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MountainTrainingApp.Data.Models.Trainer", "Trainer")
                        .WithMany("StrengthWorkouts")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MountainTrainingApp.Data.Models.TrainingPeriod", "TrainingPeriod")
                        .WithMany("StrengthWorkouts")
                        .HasForeignKey("TrainingPeriodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Athlet");

                    b.Navigation("DayOfWeek");

                    b.Navigation("StrengthWorkoutType");

                    b.Navigation("Trainer");

                    b.Navigation("TrainingPeriod");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.Trainer", b =>
                {
                    b.HasOne("MountainTrainingApp.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.AerobicActivity", b =>
                {
                    b.Navigation("AerobicWorkouts");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("AerobicWorkouts");

                    b.Navigation("Climbings");

                    b.Navigation("StrengthWorkouts");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.ClimbingActivity", b =>
                {
                    b.Navigation("Climbings");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.DayOfWeek", b =>
                {
                    b.Navigation("AerobicWorkouts");

                    b.Navigation("Climbings");

                    b.Navigation("StrengthWorkouts");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.StrengthWorkoutType", b =>
                {
                    b.Navigation("StrengthWorkouts");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.Trainer", b =>
                {
                    b.Navigation("AerobicWorkouts");

                    b.Navigation("Climbings");

                    b.Navigation("StrengthWorkouts");
                });

            modelBuilder.Entity("MountainTrainingApp.Data.Models.TrainingPeriod", b =>
                {
                    b.Navigation("AerobicWorkouts");

                    b.Navigation("Climbings");

                    b.Navigation("StrengthWorkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
