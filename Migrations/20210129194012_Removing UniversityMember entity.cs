using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Facultate.Migrations
{
    public partial class RemovingUniversityMemberentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniversityMember_ProfessorRank_rankId",
                table: "UniversityMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UniversityMember",
                table: "UniversityMember");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UniversityMember");

            migrationBuilder.RenameTable(
                name: "UniversityMember",
                newName: "Professor");

            migrationBuilder.RenameIndex(
                name: "IX_UniversityMember_rankId",
                table: "Professor",
                newName: "IX_Professor_rankId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Professor",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Professor",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Professor",
                table: "Professor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_ProfessorRank_rankId",
                table: "Professor",
                column: "rankId",
                principalTable: "ProfessorRank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professor_ProfessorRank_rankId",
                table: "Professor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Professor",
                table: "Professor");

            migrationBuilder.RenameTable(
                name: "Professor",
                newName: "UniversityMember");

            migrationBuilder.RenameIndex(
                name: "IX_Professor_rankId",
                table: "UniversityMember",
                newName: "IX_UniversityMember_rankId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UniversityMember",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UniversityMember",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "UniversityMember",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UniversityMember",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UniversityMember",
                table: "UniversityMember",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityMember_ProfessorRank_rankId",
                table: "UniversityMember",
                column: "rankId",
                principalTable: "ProfessorRank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
