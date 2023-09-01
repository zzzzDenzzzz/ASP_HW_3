using ASP_HW_3.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_HW_3.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
