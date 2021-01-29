using Microsoft.EntityFrameworkCore.Migrations;

namespace Facultate.Migrations
{
    public partial class RankIDandStatusIDprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professor_ProfessorRank_rankId",
                table: "Professor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentStatus_StatusId",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Student",
                newName: "StatusID");

            migrationBuilder.RenameIndex(
                name: "IX_Student_StatusId",
                table: "Student",
                newName: "IX_Student_StatusID");

            migrationBuilder.RenameColumn(
                name: "rankId",
                table: "Professor",
                newName: "RankID");

            migrationBuilder.RenameIndex(
                name: "IX_Professor_rankId",
                table: "Professor",
                newName: "IX_Professor_RankID");

            migrationBuilder.AlterColumn<int>(
                name: "RankID",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_ProfessorRank_RankID",
                table: "Professor",
                column: "RankID",
                principalTable: "ProfessorRank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentStatus_StatusID",
                table: "Student",
                column: "StatusID",
                principalTable: "StudentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professor_ProfessorRank_RankID",
                table: "Professor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentStatus_StatusID",
                table: "Student");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "Student",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_StatusID",
                table: "Student",
                newName: "IX_Student_StatusId");

            migrationBuilder.RenameColumn(
                name: "RankID",
                table: "Professor",
                newName: "rankId");

            migrationBuilder.RenameIndex(
                name: "IX_Professor_RankID",
                table: "Professor",
                newName: "IX_Professor_rankId");

            migrationBuilder.AlterColumn<int>(
                name: "rankId",
                table: "Professor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_ProfessorRank_rankId",
                table: "Professor",
                column: "rankId",
                principalTable: "ProfessorRank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentStatus_StatusId",
                table: "Student",
                column: "StatusId",
                principalTable: "StudentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
