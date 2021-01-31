using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsersApp.Migrations
{
    public partial class seed_agenda_table_And_client_table_ : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "IdAgenda", "Date", "IdUser", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 2, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 3, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 4, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0 },
                    { 5, new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "IdClient", "Address", "City", "ClientName", "Email", "LastNameClient", "Phone" },
                values: new object[,]
                {
                    { 1, "San Salvador", null, "Paola", null, "Franco", null },
                    { 2, "San Salvador", null, "Maria", null, "Gonzalez", null },
                    { 3, "San Salvador", null, "Carlos", null, "Gutierrez", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "LastName", "Name", "Password", "TypeUser", "UuserName" },
                values: new object[] { 3, null, null, "123", 0, "test" });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "IdAgenda", "Date", "IdUser", "State" },
                values: new object[,]
                {
                    { 6, new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 7, new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0 },
                    { 8, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 9, new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 10, new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumn: "IdAgenda",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "IdClient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "IdClient",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "IdClient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "IdUser",
                keyValue: 3);
        }
    }
}
