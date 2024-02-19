using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JPTaskAssistant.Data.JPMigrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JPDailyListTask",
                columns: new[] { "Id", "DateEntered", "Description", "EnteredBy", "IsCompleted", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("50dc569a-5a00-4fb5-b6cb-3c2295edc9ca"), new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6451), null, "James", false, "Add and Remove Tasks", 0 },
                    { new Guid("6db6ba69-466f-4b92-8851-af192810c709"), new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6408), null, "James", false, "Create New UI", 0 },
                    { new Guid("d008e31c-aa26-4acc-9641-d392183ef57c"), new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6449), null, "James", false, "Test Checking Task as Done", 0 },
                    { new Guid("dcb6a30d-34e2-4cbd-9200-2c039bf56cba"), new DateTime(2024, 2, 18, 14, 52, 17, 932, DateTimeKind.Local).AddTicks(6452), null, "James", false, "Come Up With Celebration Idea", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JPDailyListTask",
                keyColumn: "Id",
                keyValue: new Guid("50dc569a-5a00-4fb5-b6cb-3c2295edc9ca"));

            migrationBuilder.DeleteData(
                table: "JPDailyListTask",
                keyColumn: "Id",
                keyValue: new Guid("6db6ba69-466f-4b92-8851-af192810c709"));

            migrationBuilder.DeleteData(
                table: "JPDailyListTask",
                keyColumn: "Id",
                keyValue: new Guid("d008e31c-aa26-4acc-9641-d392183ef57c"));

            migrationBuilder.DeleteData(
                table: "JPDailyListTask",
                keyColumn: "Id",
                keyValue: new Guid("dcb6a30d-34e2-4cbd-9200-2c039bf56cba"));
        }
    }
}
