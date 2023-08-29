using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CondorSult_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCommentaire4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    Contenu = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserID = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArticleID = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_Commentaires_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "253e7ddd-cf59-44d8-a337-b820b3312853", "d50b307f-16df-497b-9cba-ea35b6678e7c", "Admin", "ADMIN" },
                    { "e98b2694-4a2f-4923-98f4-1e587f81b170", "da9bacd8-f117-408e-8cc8-45feb6304492", "Utilisateur", "UTILISATEUR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentaires_ArticleID",
                table: "Commentaires",
                column: "ArticleID");

            migrationBuilder.CreateIndex(
                name: "IX_Commentaires_UserID",
                table: "Commentaires",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentaires");

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
                    { "7464a5a9-68c1-4ff7-80f8-ce3a20906960", "9a351399-aae6-416d-a19a-2926c0d1de13", "Admin", "ADMIN" },
                    { "8175c8bd-ef4f-431d-8859-69f2bffa0544", "6294bec2-7783-4d6a-9f5d-030a42ffb93a", "Utilisateur", "UTILISATEUR" }
                });
        }
    }
}
