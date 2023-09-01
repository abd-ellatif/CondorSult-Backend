using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCommentaire2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a11e6bb9-d7ce-4add-a4fb-1a964f5fa258");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1af58a0-4732-415d-a35c-f55c5b32a7b7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b2e69fd-17fc-4096-ba0b-94e98716eb91", "d2d4c2e8-28e4-4e44-b4ec-d580b18fa196", "Admin", "ADMIN" },
                    { "7a859bdd-7bf7-4ea6-afae-028a56cde385", "7b978724-e43e-433f-a780-ffc8311def13", "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b2e69fd-17fc-4096-ba0b-94e98716eb91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a859bdd-7bf7-4ea6-afae-028a56cde385");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a11e6bb9-d7ce-4add-a4fb-1a964f5fa258", "fd4ec8fc-fce7-44f5-8b4c-6033f695b622", "Utilisateur", "UTILISATEUR" },
                    { "c1af58a0-4732-415d-a35c-f55c5b32a7b7", "5e5e0853-770d-48f2-b2ee-87b7b50e9e5e", "Admin", "ADMIN" }
                });
        }
    }
}
