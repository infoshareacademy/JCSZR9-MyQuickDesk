using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;
using MyQuickDesk.Resources;
using MyQuickDesk.Services;
using System.Globalization;
using System.Resources;

namespace MyQuickDesk.Controllers
{ 
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;

        public ReservationController(IReservationService reservationService, MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _reservationService = reservationService;
            _dbContext = dbContext;
            _userContext = userContext;

        }

        // GET: ReservationController
        public ActionResult Index(Guid id, Guid spaceId)
        {
            string errorMessage = Resource.ErrorReservationConflict;
            ViewBag.SpaceId = spaceId;
            if (!_userContext.IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Account");
            }

            var currentUser = _userContext.GetCurrentUser();
            var userId = currentUser.Id;

            var model = _reservationService.GetAll().Where(r => r.UserId == userId).ToList();
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
        public ActionResult Create(Guid spaceId, Guid userId)
        {
            ViewBag.SpaceId = spaceId;

            var space = _dbContext.Spaces.FirstOrDefault(s => s.Id == spaceId);
            var model = new Reservation { Space = space };
            ViewBag.UserId = userId;

            return View(model);
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Reservation model, Guid spaceId, Guid? deskId, Guid? roomId, Guid? parkingId, Guid? userId)
        {   
            try
            {
                if (ModelState.IsValid)
                {
                    var space = _dbContext.Spaces.FirstOrDefault(s => s.Id == spaceId);
                    model.Space = space;

                    var currentUser = _userContext.GetCurrentUser();
                    var user = new User
                    {
                        Id = currentUser.Id,
                    };
                    model.User = user;
                    switch (model.Space)
                    {
                        case Desk:
                            model.DeskId = spaceId;
                            break;
                        case Room:
                            model.RoomId = spaceId;
                            break;
                        case ParkingSpot:
                            model.ParkingSpotId = spaceId;
                            break;
                    }

                    if (_reservationService.IsReservationValid(model))
                    {
                        _reservationService.Create(model);
                        return RedirectToAction(nameof(Index),new {Id=model.UserId,spaceId});
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, Resource.ErrorReservationConflict);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessagePL = GetTranslatedMessage("ErrorReservationConflict", "pl-PL");  
                string errorMessageEN = GetTranslatedMessage("ErrorReservationConflict", "en-EN");
                ModelState.AddModelError(string.Empty, errorMessagePL);
                ModelState.AddModelError(string.Empty, errorMessageEN);
            }
            ViewBag.spaceId = spaceId;
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
        public ActionResult Edit(Reservation model, Guid spaceId)
        {
            try
            {
                model.Id = spaceId;
                _reservationService.Update(spaceId, model);
                return RedirectToAction(nameof(Index),new { Id = model.UserId, spaceId });
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
        public ActionResult Delete(Guid spaceId, Reservation model)
        {
            try
            {
                _reservationService.Delete(spaceId);
                return RedirectToAction(nameof(Index), new { Id = model.UserId, spaceId });
            }
            catch
            {
                return View();
            }
        }
        public static string GetTranslatedMessage(string key, string cultureCode)
        {
            ResourceManager resourceManager = new ResourceManager(typeof(Resource));
            CultureInfo culture = CultureInfo.GetCultureInfo(cultureCode);
            string translatedMessage = resourceManager.GetString(key, culture);

            return translatedMessage;
        }
    }
}

