using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCommentaire7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "253e7ddd-cf59-44d8-a337-b820b3312853");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e98b2694-4a2f-4923-98f4-1e587f81b170");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01bcf63d-55e0-4dfd-97ed-0f9e166d6e93", "dc30757c-3abd-4449-b58c-2e78735482a3", "Admin", "ADMIN" },
                    { "6797c582-c50a-427e-bd4c-3aa350ce5223", "6f9f8747-0bdc-413a-aee2-3b6ef5cac53c", "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "253e7ddd-cf59-44d8-a337-b820b3312853", "d50b307f-16df-497b-9cba-ea35b6678e7c", "Admin", "ADMIN" },
                    { "e98b2694-4a2f-4923-98f4-1e587f81b170", "da9bacd8-f117-408e-8cc8-45feb6304492", "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
