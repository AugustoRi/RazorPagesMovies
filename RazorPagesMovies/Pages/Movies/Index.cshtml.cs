using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovies.Data;
using RazorPagesMovies.Models;

namespace RazorPagesMovies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovies.Data.RazorPagesMoviesContext _context;

        public IndexModel(RazorPagesMovies.Data.RazorPagesMoviesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public string SearchInputContent { get; set; }

        [BindProperty(SupportsGet = true)]
        public string GenderMovie { get; set; }

        public SelectList Genders { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                var movies = from m in _context.Movie
                            select m;
                if (!string.IsNullOrWhiteSpace(SearchInputContent))
                {
                    movies = movies.Where(f => f.Title.Contains(SearchInputContent));
                }

                Movie = await movies.ToListAsync();
            }
        }
    }
}
