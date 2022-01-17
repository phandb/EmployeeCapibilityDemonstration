using EmployeeCapibilityDemonstration.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeCapibilityDemonstration.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "e4583f62-6e7b-47f3-a202-33fdf46b62fa",
                    Email = "admin@test.org",
                    NormalizedEmail = "ADMIN@TEST.ORG",
                    UserName = "admin@test.org",
                    NormalizedUserName = "ADMIN@TEST.ORG",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Pa$$word1"),
                    EmailConfirmed = true
                },

                new Employee
                {
                    Id = "d5683f62-7f8c-47f3-a202-33fdf46b62fa",
                    Email = "user@test.org",
                    NormalizedEmail = "USER@TEST.ORG",
                    UserName = "user@test.org",
                    NormalizedUserName = "USER@TEST.ORG",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "Pa$$word1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}