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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            //seeding the database
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Romance"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Fantasy"
                });

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
                    CategoryID = 1
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
                    CategoryID = 1
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
                    CategoryID = 2
                }
            );
        }
    }
}
