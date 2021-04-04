using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number in Stock")]
        public byte Stock { get; set; }

        
        public GenreType GenreType { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreTypeId { get; set; }

    }

    // movies/random/
}