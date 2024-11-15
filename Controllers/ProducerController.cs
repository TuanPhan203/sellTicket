using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerRepository _repo;
        public ProducerController(IProducerRepository repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var listProducer = await _repo.GetAllAsync();
            return View(listProducer);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _repo.CreateAsync(producer);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            var producer =await _repo.GetByIdAsync(id); 
            if (producer == null) {
                return BadRequest("Khong tim thay producer can xoa");
            }
            return View(producer);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producer producer)
        {
            if (!ModelState.IsValid)
                return BadRequest("Err edit is not valid");
            await _repo.UpdateAsync(id, producer);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int id) {
             var pro = await _repo.GetByIdAsync(id);
            return View(pro);
        }
        public async Task<IActionResult> Delete(int id) {
            var pro = await _repo.GetByIdAsync(id);
            if(pro == null)
            {
                return BadRequest("delete error");
            }
            _repo.DeleteAsync(id);
            return RedirectToAction("Index");
        }
       
    }
}
