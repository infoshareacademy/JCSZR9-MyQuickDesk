using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Services;
using MyQuickDesk.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using MyQuickDesk.Entities;


namespace MyQuickDesk.Controllers
{
    
    public class ParkingController : Controller
    {
        private readonly IParkingService _parkingService;

        public ParkingController(IParkingService parkingService)
        {
            _parkingService = parkingService;
        }

        // GET: ParkingController
        public ActionResult Index()
        {
            var model = _parkingService.GetAll();
            return View(model);
        }

        // GET: ParkingController/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _parkingService.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }


        // GET: ParkingController/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Guid id)
        {
            var model = new ParkingSpot { Id = id };
            return View(model);
        }

        // POST: ParkingController/Create
        [HttpPost]
        [Route("ParkingSpot/Create/{id?}")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParkingSpot model)
        {
            try
            {
                _parkingService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParkingController/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid id)
        {
            var model = _parkingService.GetById(id);
            return View(model);
        }

        // POST: ParkingController/Edit/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, ParkingSpot model)
        {
            try
            {
                _parkingService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ParkingController/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid id)
        {
            var model = _parkingService.GetById(id);
            return View(model);
        }

        // POST: ParkingController/Delete/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, ParkingSpot model)
        {
            try
            {
                _parkingService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
