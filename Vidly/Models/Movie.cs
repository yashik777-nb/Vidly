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

        [Required(ErrorMessage = "Please enter Movie Name")]
        [StringLength(25)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Release Date")]
        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter Date Added")]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please enter the stock")]
        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public byte Stock { get; set; }

        
        public GenreType GenreType { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please Choose A Genre")]
        public byte GenreTypeId { get; set; }

    }

    // movies/random/
}