using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Services;
using MyQuickDesk.Models;

namespace MyQuickDesk.Controllers
{
    public class ParkingController : Controller
    {
        private readonly ParkingService _parkingService;

        public ParkingController()
        {
            _parkingService= new ParkingService(); 
        }

        // GET: ParkingController
        public ActionResult Index()
        {
            var model = _parkingService.GetAllAvaible();
            return View(model);
        }

        // GET: ParkingController/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _parkingService.GetById(id);
            return View(model);
        }

        // GET: ParkingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ParkingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParkingController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ParkingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParkingController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ParkingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
