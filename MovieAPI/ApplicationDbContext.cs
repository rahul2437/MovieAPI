using Microsoft.EntityFrameworkCore;
using MovieAPI.Entities;
using System.Diagnostics.CodeAnalysis;

namespace MovieAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}
