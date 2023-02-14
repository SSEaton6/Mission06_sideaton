using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sideaton.Models
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options): base(options)
        {

        }
        public DbSet<Movie> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    MovieTitle = "Pride & Prejudice",
                    MovieDirector = "Joe Wright",
                    MovieYear = 2005,
                    Edited = false,
                    MovieRating = "PG",
                    Notes = "",
                    LentTo = "",
                    Category = "Romance/Fiction"
                },
                new Movie
                {
                    MovieID = 2,
                    MovieTitle = "Prince of Egypt",
                    MovieDirector = "Brenda Chapman",
                    MovieYear = 1998,
                    Edited = false,
                    MovieRating = "PG",
                    Notes = "",
                    LentTo = "",
                    Category = "Musical/Fantasy"
                },
                new Movie
                {
                    MovieID = 3,
                    MovieTitle = "Howl's Moving Castle",
                    MovieDirector = "Hayao Miyazaki",
                    MovieYear = 2004,
                    Edited = false,
                    MovieRating = "PG",
                    Notes = "",
                    LentTo = "",
                    Category = "Romance/Fiction/Children's"
                }
            );
        }
    }
}
