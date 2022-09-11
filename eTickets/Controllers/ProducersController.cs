using eTickets.Data.Repositories;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    [Authorize(Roles = UserRoles.Admin )]
    public class ProducersController : Controller
    {
        private readonly IProducerRepository _producerRepository;

        public ProducersController(IProducerRepository producerRepository)
        {
            _producerRepository = producerRepository;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var producers = await _producerRepository.GetAllAsync();
            return View(producers);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _producerRepository.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureURL,FullName,Bio")]Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);
            await _producerRepository.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _producerRepository.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,ProfilePictureURL,FullName,Bio")] Producer producer)
        {
            if (!ModelState.IsValid) return View(producer);

            if(id == producer.Id)
            {
                await _producerRepository.UpdateAsync(id, producer);
                return RedirectToAction(nameof(Index));
            }

            return View(producer);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _producerRepository.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = await _producerRepository.GetByIdAsync(id);
            if (producerDetails == null) return View("NotFound");

            await _producerRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
