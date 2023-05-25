using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebshopApp.Data;

namespace WebshopApp.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public CinemasController(ApplicationContext applicationContext)
        {
            this.applicationContext=applicationContext;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var allCinemas = await applicationContext.Cinemas.ToListAsync();
            return View(allCinemas);
        }
    }
}
