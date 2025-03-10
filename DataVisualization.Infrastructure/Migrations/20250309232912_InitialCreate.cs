using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataVisualization.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Units = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesData", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SalesData",
                columns: new[] { "Id", "Amount", "Date", "Product", "Region", "Units" },
                values: new object[,]
                {
                    { 1, 1200.50m, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop", "North", 5 },
                    { 2, 800.25m, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smartphone", "South", 10 },
                    { 3, 2400.75m, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop", "East", 8 },
                    { 4, 650.00m, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tablet", "West", 7 },
                    { 5, 950.50m, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desktop", "North", 3 },
                    { 6, 1600.75m, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smartphone", "East", 20 },
                    { 7, 975.25m, new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tablet", "South", 12 },
                    { 8, 1900.00m, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Desktop", "West", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesData");
        }
    }
}
