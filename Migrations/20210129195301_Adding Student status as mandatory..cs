using Microsoft.EntityFrameworkCore.Migrations;

namespace Facultate.Migrations
{
    public partial class AddingStudentstatusasmandatory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentStatus_StatusId",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Student",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentStatus_StatusId",
                table: "Student",
                column: "StatusId",
                principalTable: "StudentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_StudentStatus_StatusId",
                table: "Student");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Student_StudentStatus_StatusId",
                table: "Student",
                column: "StatusId",
                principalTable: "StudentStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
