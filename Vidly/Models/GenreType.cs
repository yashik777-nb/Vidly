using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class GenreType
    {
        public byte Id { get; set; }

        [StringLength(30)]
        public string GenreName { get; set; }
    }
}