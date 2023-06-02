using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Entities;
using MyQuickDesk.Services;

namespace MyQuickDesk.Controllers
{
    public class DeskController : Controller
    {
        private readonly DeskService _deskService;

        public DeskController(DeskService deskService)
        {
            _deskService = deskService;
        }

        // GET: DeskController
        public ActionResult Index()
        {
            var model = _deskService.GetAll();
            return View(model);
        }

        // GET: DeskController/Details/5
        public ActionResult Details(int id)
        {
            var model = _deskService.GetById(id);
            return View(model);
        }

        // GET: DeskController/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: DeskController/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Desk model)
        {
            try
            {
                _deskService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeskController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _deskService.GetById(id);
            return View(model);
        }

        // POST: DeskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Desk model)
        {
            try
            {
                _deskService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DeskController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _deskService.GetById(id);
            return View(model);
        }

        // POST: DeskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Desk model)
        {
            try
            {
                _deskService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
