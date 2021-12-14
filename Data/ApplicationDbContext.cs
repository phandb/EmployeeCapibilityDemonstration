using EmployeeCapibilityDemonstration.Configurations.Entities;
using EmployeeCapibilityDemonstration.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


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




        // public DbSet<MethodViewModel> MethodViewModel { get; set; }
        /*
        public DbSet<EmployeeViewModel> EmployeeViewModel { get; set; }
        
        public DbSet<CategoryViewModel> CategoryViewModel { get; set; }
        */

   
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            // Auto generate Primary Key 
            builder.Entity<Method>()
                .Property(m => m.MethodId)
                .ValueGeneratedOnAdd();

            builder.Entity<Category>()
                .Property(m => m.CategoryId)
                .ValueGeneratedOnAdd();

            //Many to many relationship between Employee and Method Using 2 one-to-many
            builder.Entity<EmployeeMethod>()
                .HasKey(em => new { em.Id, em.MethodId });

            builder.Entity<EmployeeMethod>()
                .HasOne(e => e.Employee)
                .WithMany(em => em.EmployeeMethods)
                .HasForeignKey(em => em.Id);
            //.IsRequired();

            builder.Entity<EmployeeMethod>()
                .HasOne(m => m.Method)
                .WithMany(em => em.EmployeeMethods)
                .HasForeignKey(em => em.MethodId);
                

            //Many to many relationship between Employee and Category
            builder.Entity<EmployeeCategory>()
                .HasKey(ec => new { ec.Id, ec.CategoryId });

            builder.Entity<EmployeeCategory>()
                .HasOne(e => e.Employee)
                .WithMany(ec => ec.EmployeeCategories)
                .HasForeignKey(ec => ec.Id);

            builder.Entity<EmployeeCategory>()
                .HasOne(c => c.Category)
                .WithMany(ec => ec.EmployeeCategories)
                .HasForeignKey(ec => ec.CategoryId);

            // Configure Roles
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());

        }
    }
}