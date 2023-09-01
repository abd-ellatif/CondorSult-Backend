using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUserIdType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3faa4286-972a-40db-8ad5-d6330f2ea503");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "764b0d05-1099-467f-9af4-1e9105a1dea7");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Commentaires",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Addresse",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9fb97c16-2cdb-4089-81b6-ad15b1d18e10", "fef7daac-16f1-40d5-b8a8-f25247537fcc", "Admin", "ADMIN" },
                    { "ab5163fe-2f52-40e9-913c-6f561476740b", "b270078b-7bdf-4673-95cd-eca5eef37dcc", "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb97c16-2cdb-4089-81b6-ad15b1d18e10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab5163fe-2f52-40e9-913c-6f561476740b");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Commentaires",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Addresse",
                keyValue: null,
                column: "Addresse",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Addresse",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3faa4286-972a-40db-8ad5-d6330f2ea503", "014b340e-95b2-485c-85fd-3eaf1e648810", "Utilisateur", "UTILISATEUR" },
                    { "764b0d05-1099-467f-9af4-1e9105a1dea7", "afdf33d2-4f6f-4307-b01d-53d36514a66f", "Admin", "ADMIN" }
                });
        }
    }
}
