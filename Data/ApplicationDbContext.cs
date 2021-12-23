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


            // One Method has many category relationship
            builder.Entity<Category>()
                .HasOne<Method>(m => m.Method)
                .WithMany(c => c.Categories)
                .HasForeignKey(c => c.MethodId)
                .OnDelete(DeleteBehavior.Restrict);




            // public DbSet<MethodViewModel> MethodViewModel { get; set; }
            /*
            public DbSet<EmployeeViewModel> EmployeeViewModel { get; set; }

            public DbSet<CategoryViewModel> CategoryViewModel { get; set; }
            */


            // public DbSet<EmployeeCapibilityDemonstration.ViewModels.Employee.EmployeeListViewModel> EmployeeListViewModel { get; set; }
        }
    }
}