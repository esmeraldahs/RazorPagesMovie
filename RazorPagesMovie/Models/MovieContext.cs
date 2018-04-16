using Microsoft.EntityFrameworkCore;

namespace RazorPagesMovie.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
               : base(options)
        {
        }
        //DbSet is a property for the entity set
        //an entity set corresponds to a database table
        //an entity corresponds to a row in the table
        public DbSet<Movie> Movie { get; set; }
    }
}
