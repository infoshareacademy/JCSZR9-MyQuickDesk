using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Services;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Controllers
{
    public class RoomController : Controller
    {
        private readonly RoomService _roomService;
        
        public RoomController(RoomService roomService)
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
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
        public ActionResult Edit(Guid id)
        {
            var model = _roomService.GetById(id);
            return View(model);
        }

        // POST: RoomController/Edit/5
        [HttpPost]
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
        public ActionResult Delete(Guid id)
        {
            var model = _roomService.GetById(id);
            return View(model);
        }

        // POST: RoomController/Delete/5
        [HttpPost]
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
