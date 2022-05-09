using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENG_learning_website.Migrations
{
    public partial class repp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Tasks_TaskId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Lessons_LessonId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Assignment");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_LessonId",
                table: "Assignment",
                newName: "IX_Assignment_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Assignment_TaskId",
                table: "Answers",
                column: "TaskId",
                principalTable: "Assignment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Lessons_LessonId",
                table: "Assignment",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Assignment_TaskId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Lessons_LessonId",
                table: "Assignment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignment",
                table: "Assignment");

            migrationBuilder.RenameTable(
                name: "Assignment",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_Assignment_LessonId",
                table: "Tasks",
                newName: "IX_Tasks_LessonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Tasks_TaskId",
                table: "Answers",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Lessons_LessonId",
                table: "Tasks",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
