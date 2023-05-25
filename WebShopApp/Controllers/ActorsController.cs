using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            var data = applicationContext.Actors.ToList();
            return View(data);
        }
    }
}
