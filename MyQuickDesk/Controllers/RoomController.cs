using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MyQuickDesk.DAL.Repository;
using MyQuickDesk.DAL.Entities;
using Microsoft.AspNetCore.Authorization;

namespace MyQuickDesk.Controllers
{
    
    public class RoomController : Controller
    {
        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        // GET: RoomController
        public async Task <IActionResult> Index()
        {
            var model =await _roomRepository.GetAllAsync();
            return View(model);
        }

        // GET: RoomController/Details/5
        public async Task <IActionResult> Details(Guid id)
        {

            var model =await _roomRepository.GetByIdAsync(id);
            return View(model);
        }

        // GET: RoomController/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create(Guid id)
        {
            var model = new Room { Id = id };
            return View(model);
        }

        // POST: RoomController/Create
        [HttpPost]
        [Route("Room/Create/{id?}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(Room model)
        {
            try
            {
                await _roomRepository.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task <IActionResult> Edit(Guid id)
        {
            var model = await _roomRepository.GetByIdAsync(id);
            return View(model);
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Edit(Guid id, Room model)
        {
            try
            {
                await _roomRepository.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task <IActionResult> Delete(Guid id)
        {
            var model = await _roomRepository.GetByIdAsync(id);
            return View(model);
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Delete(Guid id, Room model)
        {
            try
            {
                await _roomRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
