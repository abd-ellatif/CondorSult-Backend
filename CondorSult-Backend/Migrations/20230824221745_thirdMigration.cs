using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variantes_Articles_ArticleID",
                table: "Variantes");

            migrationBuilder.RenameColumn(
                name: "ArticleID",
                table: "Variantes",
                newName: "ArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_Variantes_ArticleID",
                table: "Variantes",
                newName: "IX_Variantes_ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Variantes_Articles_ArticleId",
                table: "Variantes",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variantes_Articles_ArticleId",
                table: "Variantes");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Variantes",
                newName: "ArticleID");

            migrationBuilder.RenameIndex(
                name: "IX_Variantes_ArticleId",
                table: "Variantes",
                newName: "IX_Variantes_ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Variantes_Articles_ArticleID",
                table: "Variantes",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
