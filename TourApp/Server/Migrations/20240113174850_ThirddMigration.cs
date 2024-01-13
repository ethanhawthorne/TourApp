using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TourApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class ThirddMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c36f80f-1d29-49ca-830c-ea8ce1512ef7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "92473554-2bc8-4260-b1b2-14fc0e87ffd4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1598b1a3-175e-4d61-a0d8-8dd926256865", null, "customer", "customer" },
                    { "99237291-8aba-47b6-ac64-20b710225e64", null, "manager", "manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1598b1a3-175e-4d61-a0d8-8dd926256865");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99237291-8aba-47b6-ac64-20b710225e64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c36f80f-1d29-49ca-830c-ea8ce1512ef7", null, "manager", "manager" },
                    { "92473554-2bc8-4260-b1b2-14fc0e87ffd4", null, "customer", "customer" }
                });
        }
    }
}
