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
            var data =  await _service.GetAllAsync();
            return View(data);
        }
        public async Task<IActionResult> CreateAsync()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DetailsAsync(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails==null) 
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }
        public async Task<IActionResult> EditAsync(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails==null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }
        [HttpPost]
        public async Task<IActionResult> EditAsync(int id, [Bind("Id, FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails==null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id, [Bind("Id, FullName,ProfilePictureURL,Bio")] Actor actor)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails==null)
            {
                return View("NotFound");
            }

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
