using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1c6e6c89-9e39-494c-9b6b-0b925a7f38a3",
                    UserId = "e2389b3d-6bea-4b12-9738-c63f0415978b",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "3d5a6c89-9f40-494c-9c7b-0b925b7c38a3",
                    UserId = "c500d542-164e-4c67-b309-51a739b05f16",
                }
                );
        }
    }
}