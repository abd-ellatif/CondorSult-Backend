using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "37c856dc-d037-4364-a77b-ed6309a6c7bb", "f3b6807c-178c-48d4-8fa5-7cd3361ac118", "Admin", "ADMIN" },
                    { "8a43a855-cac2-4472-b473-07e4ffee0f48", "4bcfcef4-9385-4bbc-928f-cc2e7b3b583a", "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37c856dc-d037-4364-a77b-ed6309a6c7bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a43a855-cac2-4472-b473-07e4ffee0f48");
        }
    }
}
