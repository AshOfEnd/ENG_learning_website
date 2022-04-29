using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENG_learning_website.Migrations
{
    public partial class tabele : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subscription = table.Column<bool>(type: "bit", nullable: false),
                    points = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Dictionary",
                columns: table => new
                {
                    DictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    meaningPl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    meaningOb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dictionary", x => x.DictId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoobsHolder = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DicId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_Dictionary_DicId",
                        column: x => x.DicId,
                        principalTable: "Dictionary",
                        principalColumn: "DictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Tasks_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Tasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientLang",
                columns: table => new
                {
                    LangId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientLang", x => new { x.ClientId, x.LangId });
                    table.ForeignKey(
                        name: "FK_ClientLang_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientLang_Languages_LangId",
                        column: x => x.LangId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_LanguageId",
                table: "Courses",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TaskId",
                table: "Answers",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientLang_LangId",
                table: "ClientLang",
                column: "LangId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_DicId",
                table: "Languages",
                column: "DicId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_LessonId",
                table: "Tasks",
                column: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Languages_LanguageId",
                table: "Courses",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Languages_LanguageId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "ClientLang");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Dictionary");

            migrationBuilder.DropIndex(
                name: "IX_Courses_LanguageId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Courses");
        }
    }
}
