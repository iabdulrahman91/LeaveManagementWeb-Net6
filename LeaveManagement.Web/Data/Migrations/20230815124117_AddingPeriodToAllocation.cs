using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc22",
                column: "ConcurrencyStamp",
                value: "eb87cf25-d2b8-4d35-b215-b5d907480e51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc33",
                column: "ConcurrencyStamp",
                value: "d928d804-bc7a-49c5-954c-12576feab475");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bff6d658-fa45-4325-b644-1704269e41a2", "AQAAAAEAACcQAAAAEPelmr9rH+bPJLy1dgn2dZccg4Za7nR0RBWhNanxMyuME0segkdLq5Kr1YSnlr10yA==", "3e6ad54b-9aa3-4c18-9dcd-cc57e908de63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9b9cc4b-797b-4084-ba5e-f11055350cd9", "AQAAAAEAACcQAAAAENLjFdyU+iY6sAwuaB5zaMAzPi1A/4ao5WMpz4G9ESepSlmqxcwfJ8PnknAgKsHxyg==", "6a6e0fa7-d7e2-46ba-a8dc-de90f7d716f9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cf029e0-c6be-4229-9b61-3bffb5fd03ff", "AQAAAAEAACcQAAAAEOYSua3Vj7m7GxKZygC51c64FUca7LvN1f/2wZx7auaBC3LYFCE8rwHDmcEwnzMx8Q==", "b3d69339-ccf4-4459-b271-77798ad9512c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b55a4518-184a-40b5-b79a-eb94ffe7a359", "AQAAAAEAACcQAAAAEDh5i5X0UkocVW8+FUd2R6qYTlGK/MQ6Lw/IK7pDtjWAb3QPTmw4EV1fTfxyIadOqQ==", "990d1944-d327-4f0b-98c1-08f9acd93394" });
        }
    }
}
