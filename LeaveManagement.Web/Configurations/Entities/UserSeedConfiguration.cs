using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Data
{
    internal class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasheer = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "aa3dec27-ed9a-4d01-af19-73e83d81cc22",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasheer.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                 new Employee
                 {
                     Id = "aa3dec27-ed9a-4d01-af19-73e83d81cc33",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER1@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     NormalizedUserName = "USER1@LOCALHOST.COM",
                     Firstname = "Normal",
                     Lastname = "User",
                     PasswordHash = hasheer.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true,
                 }
            );
        }
    }
}