using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DbOperationWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class _2609010452 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "languageTable",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "English Language", "English" },
                    { 2, "Indian Language", "Hindi" },
                    { 3, "Pakistani Language", "Urdu" },
                    { 4, "European Language", "Spanish" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "languageTable",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "languageTable",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "languageTable",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "languageTable",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
