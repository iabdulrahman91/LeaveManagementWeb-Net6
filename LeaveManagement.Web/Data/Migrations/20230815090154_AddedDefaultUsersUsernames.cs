using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc22",
                column: "ConcurrencyStamp",
                value: "2f872d08-23a9-4fd7-a819-84c95d5c79ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc33",
                column: "ConcurrencyStamp",
                value: "0634b3d3-88b7-4409-be4e-fd3787868460");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc22",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1cf029e0-c6be-4229-9b61-3bffb5fd03ff", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOYSua3Vj7m7GxKZygC51c64FUca7LvN1f/2wZx7auaBC3LYFCE8rwHDmcEwnzMx8Q==", "b3d69339-ccf4-4459-b271-77798ad9512c", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc33",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b55a4518-184a-40b5-b79a-eb94ffe7a359", true, "USER1@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDh5i5X0UkocVW8+FUd2R6qYTlGK/MQ6Lw/IK7pDtjWAb3QPTmw4EV1fTfxyIadOqQ==", "990d1944-d327-4f0b-98c1-08f9acd93394", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc22",
                column: "ConcurrencyStamp",
                value: "5f46c1a1-0e33-4704-9223-68083c7b919a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc33",
                column: "ConcurrencyStamp",
                value: "60c763bb-33a1-4092-8365-be35a6346e18");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc22",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e254c642-be13-4255-a312-c5fad7584e83", false, null, "AQAAAAEAACcQAAAAEElwtN/vHQGY6LaQVPLOlbc/whUXDzz2moPbyjHJEZpb0jNqMx0Rylrfq9xX6G6LMw==", "40ab0f51-9053-4c98-b99c-65d88a931a5a", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc33",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2edf0906-343e-4cdd-868f-dc1603dba7b6", false, null, "AQAAAAEAACcQAAAAECT1gj725I/+WjBtfZNcrhNK75BBbj6TvIOywc2TlQMEgrmmWJ9GrA2quXp7V4nYCA==", "6272cf6e-ace4-4dca-bace-421494e11412", null });
        }
    }
}
