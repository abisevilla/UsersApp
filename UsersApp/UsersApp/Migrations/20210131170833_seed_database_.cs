using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersApp.Migrations
{
    public partial class seed_database_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "LastName", "Name", "Password", "TypeUser", "UuserName" },
                values: new object[] { 1, null, null, "123", 1, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "LastName", "Name", "Password", "TypeUser", "UuserName" },
                values: new object[] { 2, null, null, "123", 0, "test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 2);
        }
    }
}
