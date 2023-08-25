using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Articles_ArticleId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Variantes_Articles_ArticleId",
                table: "Variantes");

            migrationBuilder.DropColumn(
                name: "AricleID",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Variantes",
                newName: "ArticleID");

            migrationBuilder.RenameIndex(
                name: "IX_Variantes_ArticleId",
                table: "Variantes",
                newName: "IX_Variantes_ArticleID");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Images",
                newName: "ArticleID");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ArticleId",
                table: "Images",
                newName: "IX_Images_ArticleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Articles_ArticleID",
                table: "Images",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variantes_Articles_ArticleID",
                table: "Variantes",
                column: "ArticleID",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Articles_ArticleID",
                table: "Images");

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

            migrationBuilder.RenameColumn(
                name: "ArticleID",
                table: "Images",
                newName: "ArticleId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ArticleID",
                table: "Images",
                newName: "IX_Images_ArticleId");

            migrationBuilder.AddColumn<int>(
                name: "AricleID",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Articles_ArticleId",
                table: "Images",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Variantes_Articles_ArticleId",
                table: "Variantes",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
