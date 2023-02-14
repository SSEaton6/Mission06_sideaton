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
    }
}
