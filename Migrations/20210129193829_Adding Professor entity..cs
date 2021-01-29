using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Facultate.Migrations
{
    public partial class AddingProfessorentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "UniversityMember",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "UniversityMember",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "UniversityMember",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rankId",
                table: "UniversityMember",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "UniversityMember",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityMember_rankId",
                table: "UniversityMember",
                column: "rankId");

            migrationBuilder.AddForeignKey(
                name: "FK_UniversityMember_ProfessorRank_rankId",
                table: "UniversityMember",
                column: "rankId",
                principalTable: "ProfessorRank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UniversityMember_ProfessorRank_rankId",
                table: "UniversityMember");

            migrationBuilder.DropIndex(
                name: "IX_UniversityMember_rankId",
                table: "UniversityMember");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "UniversityMember");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "UniversityMember");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "UniversityMember");

            migrationBuilder.DropColumn(
                name: "rankId",
                table: "UniversityMember");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "UniversityMember");
        }
    }
}
