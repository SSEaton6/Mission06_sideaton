// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_sideaton.Models;

namespace Mission06_sideaton.Migrations
{
    [DbContext(typeof(MovieDatabaseContext))]
    [Migration("20230214054001_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_sideaton.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.HasKey("MovieID");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Romance/Fiction",
                            Edited = false,
                            LentTo = "",
                            MovieDirector = "Joe Wright",
                            MovieRating = "PG",
                            MovieTitle = "Pride & Prejudice",
                            MovieYear = 2005,
                            Notes = ""
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Musical/Fantasy",
                            Edited = false,
                            LentTo = "",
                            MovieDirector = "Brenda Chapman",
                            MovieRating = "PG",
                            MovieTitle = "Prince of Egypt",
                            MovieYear = 1998,
                            Notes = ""
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Romance/Fiction/Children's",
                            Edited = false,
                            LentTo = "",
                            MovieDirector = "Hayao Miyazaki",
                            MovieRating = "PG",
                            MovieTitle = "Howl's Moving Castle",
                            MovieYear = 2004,
                            Notes = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
