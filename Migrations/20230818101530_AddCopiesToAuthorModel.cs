using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookish.Migrations
{
    /// <inheritdoc />
    public partial class AddCopiesToAuthorModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorModelId",
                table: "Copies",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Copies_AuthorModelId",
                table: "Copies",
                column: "AuthorModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Copies_Authors_AuthorModelId",
                table: "Copies",
                column: "AuthorModelId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Copies_Authors_AuthorModelId",
                table: "Copies");

            migrationBuilder.DropIndex(
                name: "IX_Copies_AuthorModelId",
                table: "Copies");

            migrationBuilder.DropColumn(
                name: "AuthorModelId",
                table: "Copies");
        }
    }
}
