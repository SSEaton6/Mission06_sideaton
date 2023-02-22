﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_sideaton.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage ="You must include a Movie Name")]
        public string MovieTitle { get; set; }
        [Required(ErrorMessage = "You must include a Movie Director")]
        public string MovieDirector { get; set; }
        [Required]
        public int MovieYear { get; set; }
        public bool Edited { get; set; }
        [Required]
        public string MovieRating { get; set; }
        public string Notes { get; set; }
        public string LentTo { get; set; }
        [Required(ErrorMessage = "You must include a Movie Category")]

        // Build Foreign Key relationship
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
