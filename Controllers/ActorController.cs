using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ActorController : Controller
    {
        private readonly IActorRepository _services;
        public ActorController (IActorRepository services)
        {
            _services = services;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _services.GetAllAsync();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _services.AddAsync(actor);
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public async Task<IActionResult> Detail(int id)
        {
            var actorDetail = await _services.GetActorAsync(id);
            if(actorDetail == null) return NotFound();
            return View(actorDetail);
        }
        //Get: Actor/Edit/Id=?
        public async Task<IActionResult> Edit(int id)
        {
            var actor = await _services.GetActorAsync(id);
            if (actor == null)
            {
                return NotFound();
            }
            return View(actor);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)
        {
            if (!ModelState.IsValid) 
                return View(actor);
      
            await _services.EditAsync(id,actor);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id) {
            var actor = await _services.GetActorAsync(id);
            if (actor == null) return NotFound();
            return View(actor);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteCofirm(int id)
        {
            var actorDelete =  await _services.GetActorAsync(id);
            if (actorDelete == null) return NotFound();
            await _services.DeleteAsync(id);
            return RedirectToAction("index");
        }
    }
}
