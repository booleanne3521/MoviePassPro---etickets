using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using WebshopApp.Data;

namespace WebshopApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public ActorsController(ApplicationContext applicationContext)
        {
            this.applicationContext=applicationContext;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var data = await applicationContext.Actors.ToListAsync();
            return View(data);
        }
    }
}
