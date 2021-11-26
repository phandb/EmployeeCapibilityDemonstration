using EmployeeCapibilityDemonstration.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCapibilityDemonstration.Data
{
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




            builder.Entity<Employee>()
                .HasMany(e => e.Methods)
                .WithMany(d => d.Employees);

            builder.Entity<Employee>()
               .HasMany(e => e.Categories)
               .WithMany(c => c.Employees);


        }
    }
}