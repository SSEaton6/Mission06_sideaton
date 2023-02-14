using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sideaton.Models
{
    public class Movie
    {
        public string MovieTitle { get; set; }
        public string MovieDirector { get; set; }
        public int MovieYear { get; set; }
        public bool Edited { get; set; }
        public string MovieRating { get; set; }
        public string Notes { get; set; }
        public string LentTo { get; set; }
        public string Category { get; set; }

    }
}
