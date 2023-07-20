using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Services;
using MyQuickDesk.Entities;
using Microsoft.AspNetCore.Authorization;

namespace MyQuickDesk.Controllers
{
    
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        // GET: RoomController
        public async Task <IActionResult> IndexAsync()
        {
            var model =await _roomService.GetAllAsync();
            return View(model);
        }

        // GET: RoomController/Details/5
        public async Task <IActionResult> DetailsAsync(Guid id)
        {

            var model =await _roomService.GetByIdAsync(id);
            return View(model);
        }

        // GET: RoomController/Create
        [Authorize(Roles = "Admin")]
        public async Task <IActionResult> CreateAsync(Guid id)
        {
            var model = new Room { Id = id };
            return View(model);
        }

        // POST: RoomController/Create
        [HttpPost]
        [Route("Room/Create/{id?}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> CreateAsync(Room model)
        {
            try
            {
                await _roomService.CreateAsync(model);
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task <IActionResult> EditAsync(Guid id)
        {
            var model = await _roomService.GetByIdAsync(id);
            return View(model);
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> EditAsync(Guid id, Room model)
        {
            try
            {
                await _roomService.UpdateAsync(model);
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task <IActionResult> DeleteAsync(Guid id)
        {
            var model = await _roomService.GetByIdAsync(id);
            return View(model);
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> DeleteAsync(Guid id, Room model)
        {
            try
            {
                await _roomService.DeleteAsync(id);
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}
