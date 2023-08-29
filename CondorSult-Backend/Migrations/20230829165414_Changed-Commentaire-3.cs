using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCommentaire3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaires");

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
                    { "7464a5a9-68c1-4ff7-80f8-ce3a20906960", "9a351399-aae6-416d-a19a-2926c0d1de13", "Admin", "ADMIN" },
                    { "8175c8bd-ef4f-431d-8859-69f2bffa0544", "6294bec2-7783-4d6a-9f5d-030a42ffb93a", "Utilisateur", "UTILISATEUR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7464a5a9-68c1-4ff7-80f8-ce3a20906960");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8175c8bd-ef4f-431d-8859-69f2bffa0544");

            migrationBuilder.CreateTable(
                name: "Commentaires",
                columns: table => new
                {
                    CommentaireID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArticleID = table.Column<int>(type: "int", nullable: false),
                    UtilisateurId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contenu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserID = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentaires", x => x.CommentaireID);
                    table.ForeignKey(
                        name: "FK_Commentaires_Articles_ArticleID",
                        column: x => x.ArticleID,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commentaires_AspNetUsers_UtilisateurId",
                        column: x => x.UtilisateurId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b2e69fd-17fc-4096-ba0b-94e98716eb91", "d2d4c2e8-28e4-4e44-b4ec-d580b18fa196", "Admin", "ADMIN" },
                    { "7a859bdd-7bf7-4ea6-afae-028a56cde385", "7b978724-e43e-433f-a780-ffc8311def13", "Utilisateur", "UTILISATEUR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentaires_ArticleID",
                table: "Commentaires",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaires_UtilisateurId",
                table: "Commentaires",
                column: "UtilisateurId");
        }
    }
}
