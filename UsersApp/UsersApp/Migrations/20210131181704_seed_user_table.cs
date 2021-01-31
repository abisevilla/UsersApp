using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersApp.Migrations
{
    public partial class seed_user_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "admin1", "admin 1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 2,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "testing", "tester 1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 3,
                columns: new[] { "LastName", "Name" },
                values: new object[] { "test", "tester 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1,
                columns: new[] { "LastName", "Name" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 2,
                columns: new[] { "LastName", "Name" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 3,
                columns: new[] { "LastName", "Name" },
                values: new object[] { null, null });
        }
    }
}
