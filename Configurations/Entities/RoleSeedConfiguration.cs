using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeCapibilityDemonstration.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"

                },

                new IdentityRole
                {
                    Id = "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                    Name = "User",
                    NormalizedName = "USER"

                }

                
            );
        }
    }
}