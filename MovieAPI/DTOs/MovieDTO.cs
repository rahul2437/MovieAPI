﻿using System.ComponentModel.DataAnnotations;

namespace MovieAPI.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Trailer { get; set; }

        public Boolean InTheaters { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Poster { get; set; }

        public List<GenreDTO> Genres { get; set; }

        public List<MovieTheaterDTO> MovieTheaters { get; set; }

        public List<ActorsMovieDTO> Actors { get; set; }
    }
}
