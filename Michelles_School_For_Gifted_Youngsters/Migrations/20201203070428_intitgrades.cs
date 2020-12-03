using Microsoft.EntityFrameworkCore.Migrations;

namespace Michelles_School_For_Gifted_Youngsters.Migrations
{
    public partial class intitgrades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GradesID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentGradesID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GradeSheet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemScore = table.Column<int>(nullable: false),
                    ItemTotal = table.Column<int>(nullable: false),
                    ItemGrade = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradeSheet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GradesForTerm",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Term = table.Column<int>(nullable: false),
                    quiz1 = table.Column<int>(nullable: true),
                    quiz2 = table.Column<int>(nullable: true),
                    quiz3 = table.Column<int>(nullable: true),
                    assignment1 = table.Column<int>(nullable: true),
                    assignment2 = table.Column<int>(nullable: true),
                    assignment3 = table.Column<int>(nullable: true),
                    GradeSheetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GradesForTerm", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GradesForTerm_GradeSheet_GradeSheetID",
                        column: x => x.GradeSheetID,
                        principalTable: "GradeSheet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentGrades",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prelim = table.Column<int>(nullable: true),
                    Midterm = table.Column<int>(nullable: true),
                    PreFinals = table.Column<int>(nullable: true),
                    Finals = table.Column<int>(nullable: true),
                    TotalGrade = table.Column<float>(nullable: false),
                    GradesForTermID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentGrades", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentGrades_GradesForTerm_GradesForTermID",
                        column: x => x.GradesForTermID,
                        principalTable: "GradesForTerm",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_StudentGradesID",
                table: "AspNetUsers",
                column: "StudentGradesID");

            migrationBuilder.CreateIndex(
                name: "IX_GradesForTerm_GradeSheetID",
                table: "GradesForTerm",
                column: "GradeSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentGrades_GradesForTermID",
                table: "StudentGrades",
                column: "GradesForTermID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_StudentGrades_StudentGradesID",
                table: "AspNetUsers",
                column: "StudentGradesID",
                principalTable: "StudentGrades",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_StudentGrades_StudentGradesID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "StudentGrades");

            migrationBuilder.DropTable(
                name: "GradesForTerm");

            migrationBuilder.DropTable(
                name: "GradeSheet");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_StudentGradesID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GradesID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudentGradesID",
                table: "AspNetUsers");
        }
    }
}
