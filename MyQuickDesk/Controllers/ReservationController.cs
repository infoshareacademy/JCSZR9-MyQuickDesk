using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Entities;
using MyQuickDesk.Services;

namespace MyQuickDesk.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IDeskService _deskService;
        private readonly IReservationService _reservationService;
        public ReservationController (IReservationService reservationService, IDeskService deskService)
        {
            _reservationService = reservationService;
            _deskService = deskService;
        }
        // GET: ReservationController
        public ActionResult Index()
        {
            var model = _reservationService.GetAll();
            return View(model);
        }

        // GET: ReservationController/Details/5
        public ActionResult Details(Guid id)
        {
            var model = _reservationService.GetById(id);
            return View(model);
        }

        // GET: ReservationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reservation reservation, Guid deskId)
        {
            try
            {
                reservation.DeskId = deskId;
                _deskService.BookReservationForDesk(reservation, deskId);
                _reservationService.Create(reservation);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservationController/Edit/5
        public ActionResult Edit(Guid id)
        { 
            var model = _reservationService.GetById(id);
            return View();
        }

        // POST: ReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Reservation model)
        {
            try
            {
                _reservationService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
       
        // GET: ReservationController/Delete/5
        public ActionResult Delete(Guid id)
        { 
            var model = _reservationService.GetById(id);
            return View();
        }

        // POST: ReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Reservation model)
        {
            try
            {
                _reservationService.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
