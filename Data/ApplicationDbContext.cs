using EmployeeCapibilityDemonstration.Configurations.Entities;
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

        public DbSet<MethodCategory> MethodCategories { get; set; }
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

            builder.Entity<MethodCategory>()
                .HasKey(em => new { em.MethodId, em.CategoryId });

            builder.Entity<MethodCategory>()
                .HasOne(e => e.Method)
                .WithMany(em => em.MethodCategories)
                .HasForeignKey(em => em.MethodId)
                .OnDelete(DeleteBehavior.Restrict); ;
            //.IsRequired();

            builder.Entity<MethodCategory>()
                .HasOne(m => m.Category)
                .WithMany(em => em.MethodCategories)
                .HasForeignKey(em => em.CategoryId)
                .OnDelete(DeleteBehavior.Restrict); ;
                     


            foreach (var foreignKey in builder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
               
        
    }
}