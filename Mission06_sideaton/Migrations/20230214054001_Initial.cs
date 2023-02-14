using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_sideaton.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Category = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 1, "Romance/Fiction", false, "", "Joe Wright", "PG", "Pride & Prejudice", 2005, "" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 2, "Musical/Fantasy", false, "", "Brenda Chapman", "PG", "Prince of Egypt", 1998, "" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieID", "Category", "Edited", "LentTo", "MovieDirector", "MovieRating", "MovieTitle", "MovieYear", "Notes" },
                values: new object[] { 3, "Romance/Fiction/Children's", false, "", "Hayao Miyazaki", "PG", "Howl's Moving Castle", 2004, "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
