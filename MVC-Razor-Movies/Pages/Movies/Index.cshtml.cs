using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVC_Razor_Movies.Data;
using MVC_Razor_Movies.Models;

namespace MVC_Razor_Movies.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MVC_Razor_Movies.Data.ApplicationDbContext _context;

        public IndexModel(MVC_Razor_Movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
