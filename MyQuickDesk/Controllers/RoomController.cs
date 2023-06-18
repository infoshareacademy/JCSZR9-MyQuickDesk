using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Services;
using MyQuickDesk.Entities;
using Microsoft.AspNetCore.Authorization;
using System.Data;

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
        public ActionResult Index()
        {
            bool ConditionGuideractiveBoard = true;

            if (ConditionGuideractiveBoard)
            {
                ViewBag.ConditionGuideractiveBoard = "yes";
            }
            else
            {
                ViewBag.ConditionGuideractiveBoard = "no";
            }
            var model = _roomService.GetAll();
            return View(model);
        }

        // GET: RoomController/Details/5
        public ActionResult Details(Guid id)
        {

            var model = _roomService.GetById(id);
            return View(model);
        }

        // GET: RoomController/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Guid id)
        {
           var model = new Room { Id = id };
            return View(model);
        }

        // POST: RoomController/Create
        [HttpPost]
        [Route("Room/Create/{id?}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Room model )
        {
            try
            {
                _roomService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            var model = _roomService.GetById(id);
            return View(model);
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Room model)
        {
            try
            {
                _roomService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            var model = _roomService.GetById(id);
            return View(model);
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Room model)
        {
            try
            {
                 _roomService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
