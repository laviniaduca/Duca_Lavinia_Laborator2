using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Duca_Lavinia_Laborator2.Migrations
{
    public partial class BookCategoryFixedVer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookID1",
                table: "BookCategory");

            migrationBuilder.DropIndex(
                name: "IX_BookCategory_BookID1",
                table: "BookCategory");

            migrationBuilder.DropColumn(
                name: "BookID1",
                table: "BookCategory");

            migrationBuilder.AlterColumn<int>(
                name: "BookID",
                table: "BookCategory",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_BookID",
                table: "BookCategory",
                column: "BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategory_Book_BookID",
                table: "BookCategory");

            migrationBuilder.DropIndex(
                name: "IX_BookCategory_BookID",
                table: "BookCategory");

            migrationBuilder.AlterColumn<string>(
                name: "BookID",
                table: "BookCategory",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BookID1",
                table: "BookCategory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookCategory_BookID1",
                table: "BookCategory",
                column: "BookID1");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategory_Book_BookID1",
                table: "BookCategory",
                column: "BookID1",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
