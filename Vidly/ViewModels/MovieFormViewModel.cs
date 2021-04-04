using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;


namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }
        
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter Movie Name")]
        [StringLength(25)]
        [Display(Name = "Movie Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Release Date")]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter Date Added")]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required(ErrorMessage = "Please enter the stock")]
        [Display(Name = "Number in Stock")]
        [Range(10, 20)]
        public byte? Stock { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please Choose A Genre")]
        public byte? GenreTypeId { get; set; }

        public string Title { 
            get { return Id != 0 ? "Edit Movie" : "New Movie"; } 
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            Stock = movie.Stock;
            DateAdded = movie.DateAdded;
            GenreTypeId = movie.GenreTypeId;
        }
    }
}