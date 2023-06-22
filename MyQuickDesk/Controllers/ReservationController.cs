using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;
using MyQuickDesk.Services;

namespace MyQuickDesk.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;
        

        public ReservationController(IReservationService reservationService, MyQuickDeskContext dbContext,IUserContext userContext)
        {
            _reservationService = reservationService;
            _dbContext = dbContext;
            _userContext = userContext;
        }

        // GET: ReservationController
        public ActionResult Index()
        {
                var model = _reservationService.GetAll();
                return View(model);
            
        }

        // GET: ReservationController/Details/5
        public ActionResult Details(Guid id, Guid spaceId)
        {
            ViewBag.SpaceId = spaceId;
            var model = _reservationService.GetById(id);
            return View(model);
        }

        // GET: ReservationController/Create
        public ActionResult Create(Guid spaceId)
        {
            ViewBag.SpaceId = spaceId;

            var space = _dbContext.Spaces.FirstOrDefault(s => s.Id == spaceId);
            var model = new Reservation { Space = space };

            return View(model);
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reservation model, Guid spaceId, Guid? deskId, Guid? roomId, Guid? parkingId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var space = _dbContext.Spaces.FirstOrDefault(s => s.Id == spaceId);
                    model.Space = space;

                    if (model.Space is Desk)
                    {
                        model.DeskId = spaceId;
                    }
                    else if (model.Space is Room)
                    {
                        model.RoomId = spaceId;
                    }
                    else if (model.Space is ParkingSpot)
                    {
                        model.ParkingSpotId = spaceId;
                    }
                   
                    if (_reservationService.IsReservationValid(model))
                    {
                        _reservationService.Create(model);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "The reservation conflicts with existing bookings. Please choose a different time slot.");
                    }
                }
            }
            catch
            {
                return View();
            }
            return View(model);
        }

        // GET: ReservationController/Edit/5
        public ActionResult Edit(Guid id, Guid spaceId)
        {
            ViewBag.SpaceId = spaceId;

            var model = _reservationService.GetById(id);
            return View(model);
        }

        // POST: ReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Reservation model, Guid id)
        {
            try
            {
                model.Id = id;
                _reservationService.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ReservationController/Delete/5
        public ActionResult Delete(Guid id)
        {
            var model = _reservationService.GetById(id);
            return View(model);
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

