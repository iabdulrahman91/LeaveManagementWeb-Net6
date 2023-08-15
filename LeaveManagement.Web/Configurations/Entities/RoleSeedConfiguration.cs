using LeaveManagement.Web.Constents;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "bb3dec27-ed9a-4d01-af19-73e83d81cc22",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper(),
                },
                new IdentityRole
                {
                    Id = "bb3dec27-ed9a-4d01-af19-73e83d81cc33",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                }
            );
        }
    }
}