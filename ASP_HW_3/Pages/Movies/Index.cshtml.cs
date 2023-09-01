using ASP_HW_3.Data;
using ASP_HW_3.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ASP_HW_3.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieContext _context;

        public IndexModel(MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
