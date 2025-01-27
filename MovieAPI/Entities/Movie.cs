﻿using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 75)]
        public string Title { get; set; }

        public string Summary { get; set; }
        
        public string Trailer { get; set; }
        
        public Boolean InTheaters { get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public string Poster { get; set; }

        public List<MoviesGenres> MoviesGenres { get; set; }
        
        public List<MovieTheatersMovies> MovieTheatersMovies { get; set; }

        public List<MoviesActors> MoviesActors { get; set; }
    }
}
