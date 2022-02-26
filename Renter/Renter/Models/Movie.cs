﻿using System.ComponentModel.DataAnnotations;

namespace Renter.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public byte GenreId { get; set; }

        public string DateAdded { get; set; }

        public string ReleaseDate { get;set; }

        public byte NumberInStock { get; set; }
    }
}
