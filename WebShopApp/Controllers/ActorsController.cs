using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using WebshopApp.Data;
using WebshopApp.Data.Services;
using WebshopApp.Models;

namespace WebshopApp.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
          _service = service;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var data =  await _service.GetAll();
            return View(data);
        }
        public async Task<IActionResult> CreateAsync()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
