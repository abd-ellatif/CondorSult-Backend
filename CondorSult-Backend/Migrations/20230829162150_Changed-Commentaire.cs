using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCommentaire : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb97c16-2cdb-4089-81b6-ad15b1d18e10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab5163fe-2f52-40e9-913c-6f561476740b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a11e6bb9-d7ce-4add-a4fb-1a964f5fa258", "fd4ec8fc-fce7-44f5-8b4c-6033f695b622", "Utilisateur", "UTILISATEUR" },
                    { "c1af58a0-4732-415d-a35c-f55c5b32a7b7", "5e5e0853-770d-48f2-b2ee-87b7b50e9e5e", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "9fb97c16-2cdb-4089-81b6-ad15b1d18e10", "fef7daac-16f1-40d5-b8a8-f25247537fcc", "Admin", "ADMIN" },
                    { "ab5163fe-2f52-40e9-913c-6f561476740b", "b270078b-7bdf-4673-95cd-eca5eef37dcc", "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
