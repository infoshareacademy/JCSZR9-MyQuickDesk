using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Services;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Controllers
{
    public class ParkingController : Controller
    {
        private readonly ParkingService _parkingService;
        private readonly FavoritesService _favoritesService;
        
        public ParkingController(ParkingService parkingService, FavoritesService favoritesService)
        {
            _favoritesService = favoritesService;
            _parkingService = parkingService;
        }

        // GET: ParkingController
        public ActionResult Index()
        {
            var model = _parkingService.GetAllAvaible();
            return View(model);
        }
        
        public ActionResult AddToFavorites(Guid guid)
        {
            var model = _parkingService.GetById(guid);
            _favoritesService.AddFavorite(model);
            return View (_parkingService.GetAllAvaible());

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
        public ActionResult Edit(Guid id)
        {
            return View();
        }

        // POST: ParkingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, IFormCollection collection)
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
        public ActionResult Delete(Guid id)
        {
            return View();
        }

        // POST: ParkingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
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
