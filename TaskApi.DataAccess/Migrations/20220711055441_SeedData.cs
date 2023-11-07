using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskApi.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ID", "Created", "Description", "Due", "Status", "Title" },
                values: new object[] { 1, new DateTime(2022, 7, 10, 22, 54, 40, 540, DateTimeKind.Local).AddTicks(2549), "Collect the existing Doc- from sql server", new DateTime(2022, 7, 15, 22, 54, 40, 543, DateTimeKind.Local).AddTicks(3852), 0, "project start- from sql server" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDos",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
