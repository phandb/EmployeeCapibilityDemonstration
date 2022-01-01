﻿// <auto-generated />
using System;
using EmployeeCapibilityDemonstration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeCapibilityDemonstration.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CategoryMethod", b =>
                {
                    b.Property<string>("CategoriesCategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MethodId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CategoriesCategoryId", "MethodId");

                    b.HasIndex("MethodId");

                    b.ToTable("CategoryMethod");
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<DateTime>("TakenDate")
                        .HasColumnType("datetime2");

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

                    b.HasData(
                        new
                        {
                            Id = "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "500bf10a-48ad-402d-9e4d-73cabf8059b6",
                            Email = "admin@test.org",
                            EmailConfirmed = true,
                            ExpiredDate = new DateTime(2021, 12, 31, 15, 45, 4, 127, DateTimeKind.Local).AddTicks(5646),
                            FirstName = "System",
                            HiredDate = new DateTime(2021, 12, 31, 15, 45, 4, 127, DateTimeKind.Local).AddTicks(5599),
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TEST.ORG",
                            NormalizedUserName = "ADMIN@TEST.ORG",
                            PasswordHash = "AQAAAAEAACcQAAAAEAqBS82Oq29bwO6Ld8CLJZPeBu8mNh0DDzQQGAjFDnhcF2DSFNXck24l1AzK8G9lIw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ba2d391e-69f8-4312-b6a5-7e0412d743aa",
                            TakenDate = new DateTime(2021, 12, 31, 15, 45, 4, 127, DateTimeKind.Local).AddTicks(5644),
                            TwoFactorEnabled = false,
                            UserName = "admin@test.org"
                        },
                        new
                        {
                            Id = "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0541e902-a9c6-4ec3-ba83-e011d1a4fa1e",
                            Email = "user@test.org",
                            EmailConfirmed = true,
                            ExpiredDate = new DateTime(2021, 12, 31, 15, 45, 4, 130, DateTimeKind.Local).AddTicks(4083),
                            FirstName = "System",
                            HiredDate = new DateTime(2021, 12, 31, 15, 45, 4, 130, DateTimeKind.Local).AddTicks(4065),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@TEST.ORG",
                            NormalizedUserName = "USER@TEST.ORG",
                            PasswordHash = "AQAAAAEAACcQAAAAEAngIydi8yK4Y3E2tJI+//OhWO9bcPcLXKON2vNuleIYgUw9R5d/aNS9QBmXth5c5g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d0d58eaf-8529-4e22-ac60-1737c53fc7f0",
                            TakenDate = new DateTime(2021, 12, 31, 15, 45, 4, 130, DateTimeKind.Local).AddTicks(4080),
                            TwoFactorEnabled = false,
                            UserName = "user@test.org"
                        });
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.EmployeeMethod", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MethodId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("MethodId");

                    b.ToTable("EmployeeMethod");
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.Method", b =>
                {
                    b.Property<string>("MethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MethodId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Methods");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasData(
                        new
                        {
                            Id = "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                            ConcurrencyStamp = "e524b165-e9db-4cef-aee6-6c8003c5afa2",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                            ConcurrencyStamp = "5f2a893e-2930-42b0-b4e4-b35d03b13089",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                            RoleId = "e4583f62-6e7c-47f3-a203-33fdf46b6erc"
                        },
                        new
                        {
                            UserId = "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                            RoleId = "e4583d62-6e7c-47a3-a303-33fds46b6edc"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("CategoryMethod", b =>
                {
                    b.HasOne("EmployeeCapibilityDemonstration.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EmployeeCapibilityDemonstration.Models.Method", null)
                        .WithMany()
                        .HasForeignKey("MethodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.Category", b =>
                {
                    b.HasOne("EmployeeCapibilityDemonstration.Models.Employee", null)
                        .WithMany("Category")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.EmployeeMethod", b =>
                {
                    b.HasOne("EmployeeCapibilityDemonstration.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EmployeeCapibilityDemonstration.Models.Method", "Method")
                        .WithMany("EmployeeMethods")
                        .HasForeignKey("MethodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Method");
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.Method", b =>
                {
                    b.HasOne("EmployeeCapibilityDemonstration.Models.Employee", null)
                        .WithMany("Methods")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EmployeeCapibilityDemonstration.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EmployeeCapibilityDemonstration.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EmployeeCapibilityDemonstration.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EmployeeCapibilityDemonstration.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.Employee", b =>
                {
                    b.Navigation("Category");

                    b.Navigation("Methods");
                });

            modelBuilder.Entity("EmployeeCapibilityDemonstration.Models.Method", b =>
                {
                    b.Navigation("EmployeeMethods");
                });
#pragma warning restore 612, 618
        }
    }
}
