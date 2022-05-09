using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENG_learning_website.Migrations
{
    public partial class reppId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Assignment_TaskId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_TaskId",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "AssigmentId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Answers_AssigmentId",
                table: "Answers",
                column: "AssigmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Assignment_AssigmentId",
                table: "Answers",
                column: "AssigmentId",
                principalTable: "Assignment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Assignment_AssigmentId",
                table: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Answers_AssigmentId",
                table: "Answers");

            migrationBuilder.DropColumn(
                name: "AssigmentId",
                table: "Answers");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TaskId",
                table: "Answers",
                column: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Assignment_TaskId",
                table: "Answers",
                column: "TaskId",
                principalTable: "Assignment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
