using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASP.NET_TEST.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "ID", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went Hiking with Denis", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Went Hiking" },
                    { 2, "Went Hiking with Alisson", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Went Hiking" },
                    { 3, "Went Biking with Alisson", new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Local), "Went Biking" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
