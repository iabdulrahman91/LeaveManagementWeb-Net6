using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Data
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            var hasheer = new PasswordHasher<Employee>();
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "bb3dec27-ed9a-4d01-af19-73e83d81cc22",
                    UserId = "aa3dec27-ed9a-4d01-af19-73e83d81cc22",
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bb3dec27-ed9a-4d01-af19-73e83d81cc33",
                    UserId = "aa3dec27-ed9a-4d01-af19-73e83d81cc33",
                }
            );
        }
    }
}