using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc22",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3dec27-ed9a-4d01-af19-73e83d81cc33",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc22",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa0360b0-84cd-4e0b-8b32-042103c39695", "AQAAAAIAAYagAAAAEO6dIiSAOajnditCESyQyQlqeCUXUli2VUuClNj5ggY5MW1zfRlCoVjEbeb09HFG+g==", "0282da38-a155-4638-b9c1-0af0111ab127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa3dec27-ed9a-4d01-af19-73e83d81cc33",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3b1e91-7bca-4d65-806a-9344818422a5", "AQAAAAIAAYagAAAAEJN133KAsSWpmcYhmV/5S4d4wFJWO1x76i12T3mQbazW/vpFcLhIurrliFrhnGG8TA==", "65fe02ea-1001-4327-8127-e1414b019f7e" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveAllocations_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations");

            migrationBuilder.DropIndex(
                name: "IX_LeaveAllocations_EmployeeId",
                table: "LeaveAllocations");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
    }
}
