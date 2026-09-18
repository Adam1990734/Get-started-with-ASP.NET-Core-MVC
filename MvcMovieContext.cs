using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

public class MvcMovieContext(DbContextOptions<MvcMovieContext> options) : DbContext(options)
{
    public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
}
