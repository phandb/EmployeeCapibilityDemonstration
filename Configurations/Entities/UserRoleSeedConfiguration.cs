using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeCapibilityDemonstration.Data
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData
                (
                    new IdentityUserRole<string>
                    {
                        RoleId = "e4583f62-6e7c-47f3-a203-33fdf46b6erc",
                        UserId = "e4583f62-6e7b-47f3-a202-33fdf46b62fa"

                    },

                    new IdentityUserRole<string>
                    {
                        RoleId = "e4583d62-6e7c-47a3-a303-33fds46b6edc",
                        UserId = "d5683f62-7f8c-47f3-a202-33fdf46b62fa"

                    }

                );
        }
    }
}