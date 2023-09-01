using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01bcf63d-55e0-4dfd-97ed-0f9e166d6e93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6797c582-c50a-427e-bd4c-3aa350ce5223");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f0a41a7-44e2-4c72-a476-8c0d7ad0dfaf", "f94b8188-dcab-4d01-9053-2736955b3c25", "Admin", "ADMIN" },
                    { "dbd94ede-579f-4e51-9808-9a71abe30122", "e0924685-962b-41e8-bb8f-37cfb13cf4d5", "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f0a41a7-44e2-4c72-a476-8c0d7ad0dfaf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbd94ede-579f-4e51-9808-9a71abe30122");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01bcf63d-55e0-4dfd-97ed-0f9e166d6e93", "dc30757c-3abd-4449-b58c-2e78735482a3", "Admin", "ADMIN" },
                    { "6797c582-c50a-427e-bd4c-3aa350ce5223", "6f9f8747-0bdc-413a-aee2-3b6ef5cac53c", "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
