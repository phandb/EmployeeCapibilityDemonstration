﻿using EmployeeCapibilityDemonstration.Configurations.Entities;
using EmployeeCapibilityDemonstration.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmployeeCapibilityDemonstration.ViewModels.Employee;


namespace EmployeeCapibilityDemonstration.Data
{
    // Employee inherits Identity User.
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Employee> Employees { get; set; }
        public DbSet<Method> Methods { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<EmployeeCategory> EmployeeCategories { get; set; }
        public DbSet<EmployeeMethod> EmployeeMethods{ get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure Roles
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());


            // Auto generate Primary Key 
            builder.Entity<Method>()
                .Property(m => m.MethodId)
                .ValueGeneratedOnAdd();

            builder.Entity<Category>()
                .Property(m => m.CategoryId)
                .ValueGeneratedOnAdd();

            // 
            

            //Many to many relationship between Employee and Method Using 2 one-to-many
           
            builder.Entity<EmployeeMethod>()
                .HasKey(em => new { em.Id, em.MethodId });

            builder.Entity<EmployeeMethod>()
                .HasOne(e => e.Employee)
                .WithMany(em => em.EmployeeMethods)
                .HasForeignKey(em => em.Id)
                .OnDelete(DeleteBehavior.Restrict); ;
            //.IsRequired();

            builder.Entity<EmployeeMethod>()
                .HasOne(m => m.Method)
                .WithMany(em => em.EmployeeMethods)
                .HasForeignKey(em => em.MethodId)
                .OnDelete(DeleteBehavior.Restrict); ;


            //Many to many relationship between Employee and Category Using 2 one-to-many

            builder.Entity<EmployeeCategory>()
                .HasKey(em => new { em.Id, em.CategoryId });

            builder.Entity<EmployeeCategory>()
                .HasOne(e => e.Employee)
                .WithMany(em => em.EmployeeCategories)
                .HasForeignKey(em => em.Id)
                .OnDelete(DeleteBehavior.Restrict); ;
            //.IsRequired();

            builder.Entity<EmployeeCategory>()
                .HasOne(m => m.Category)
                .WithMany(em => em.EmployeeCategories)
                .HasForeignKey(em => em.CategoryId)
                .OnDelete(DeleteBehavior.Restrict); ;


            // One Method has many category relationship

            /*
            builder.Entity<Category>()
                .HasOne<Method>(m => m.Method)
                .WithMany(c => c.Categories)
                .HasForeignKey(c => c.MethodId)
                .OnDelete(DeleteBehavior.Restrict);
           
            */


            foreach (var foreignKey in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }




        public DbSet<EmployeeCapibilityDemonstration.ViewModels.Employee.EmployeeDetailsViewModel> EmployeeDetailsViewModel { get; set; }




        
    }
}