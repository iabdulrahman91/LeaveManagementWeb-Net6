using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb3dec27-ed9a-4d01-af19-73e83d81cc22", "5f46c1a1-0e33-4704-9223-68083c7b919a", "Administrator", "ADMINISTRATOR" },
                    { "bb3dec27-ed9a-4d01-af19-73e83d81cc33", "60c763bb-33a1-4092-8365-be35a6346e18", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aa3dec27-ed9a-4d01-af19-73e83d81cc22", 0, "e254c642-be13-4255-a312-c5fad7584e83", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEElwtN/vHQGY6LaQVPLOlbc/whUXDzz2moPbyjHJEZpb0jNqMx0Rylrfq9xX6G6LMw==", null, false, "40ab0f51-9053-4c98-b99c-65d88a931a5a", null, false, null },
                    { "aa3dec27-ed9a-4d01-af19-73e83d81cc33", 0, "2edf0906-343e-4cdd-868f-dc1603dba7b6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "Normal", "User", false, null, "USER1@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAECT1gj725I/+WjBtfZNcrhNK75BBbj6TvIOywc2TlQMEgrmmWJ9GrA2quXp7V4nYCA==", null, false, "6272cf6e-ace4-4dca-bace-421494e11412", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb3dec27-ed9a-4d01-af19-73e83d81cc22", "aa3dec27-ed9a-4d01-af19-73e83d81cc22" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb3dec27-ed9a-4d01-af19-73e83d81cc33", "aa3dec27-ed9a-4d01-af19-73e83d81cc33" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb3dec27-ed9a-4d01-af19-73e83d81cc22", "aa3dec27-ed9a-4d01-af19-73e83d81cc22" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb3dec27-ed9a-4d01-af19-73e83d81cc33", "aa3dec27-ed9a-4d01-af19-73e83d81cc33" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc33");
        }
    }
}
