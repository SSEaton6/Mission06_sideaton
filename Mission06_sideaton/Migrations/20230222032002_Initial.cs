using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_sideaton.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(nullable: false),
                    MovieDirector = table.Column<string>(nullable: false),
                    MovieYear = table.Column<int>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    MovieRating = table.Column<string>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    LentTo = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_responses_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Romance" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Fantasy" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "CategoryID", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 1, 1, false, "", "Joe Wright", "PG", "Pride & Prejudice", 2005, "" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "CategoryID", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 2, 1, false, "", "Brenda Chapman", "PG", "Prince of Egypt", 1998, "" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "CategoryID", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 3, 2, false, "", "Hayao Miyazaki", "PG", "Howl's Moving Castle", 2004, "" });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryID",
                table: "responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
