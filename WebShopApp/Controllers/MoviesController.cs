using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebshopApp.Data;

namespace WebshopApp.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public MoviesController(ApplicationContext applicationContext)
        {
            this.applicationContext=applicationContext;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var allMovies = await applicationContext.Movies.ToListAsync();
            return View(allMovies);
        }
    }
}
