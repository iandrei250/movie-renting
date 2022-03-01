using Renter.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Renter.ViewModels
{
    public class MovieFormViewModel
    {

        public int? Id { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public string? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        [Required]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
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
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}
