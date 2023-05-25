using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebshopApp.Data;

namespace WebshopApp.Controllers
{
    public class ProducersController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public ProducersController(ApplicationContext applicationContext)
        {
            this.applicationContext=applicationContext;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var allProducers = await applicationContext.Producers.ToListAsync();
            return View(allProducers);
        }
    }
}
