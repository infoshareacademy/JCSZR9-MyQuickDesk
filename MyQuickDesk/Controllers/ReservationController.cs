using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.DAL.ApplicationUser;
using MyQuickDesk.DAL.DatabaseContext;
using MyQuickDesk.DAL.Entities;
using MyQuickDesk.Resources;
using MyQuickDesk.DAL.Repository;
using System.Globalization;
using System.Resources;


namespace MyQuickDesk.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;

        public ReservationController(IReservationRepository reservationService, MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _reservationRepository = reservationService;
            _dbContext = dbContext;
            _userContext = userContext;

        }

        // GET: ReservationController
        public async Task<IActionResult> Index(Guid id, Guid spaceId)
        {
            string errorMessage = Resource.ErrorReservationConflict;
            ViewBag.SpaceId = spaceId;
            if (!_userContext.IsUserLoggedIn())
            {
                return RedirectToAction("Login", "Account");
            }

            var currentUser = _userContext.GetCurrentUser();
            var userId = currentUser.Id;
            var currentDate = DateTime.Today;

            var reservations = await _reservationRepository.GetAllAsync();
            var model = reservations.Where(r => r.UserId == userId && r.EndTime >= currentDate).ToList();

            return View(model);
        }

        // GET: ReservationController/Details/5
        public async Task<IActionResult> Details(Guid id, Guid spaceId)
        {
            ViewBag.SpaceId = spaceId;
            var model = await _reservationRepository.GetByIdAsync(id);
            return View(model);
        }

        // GET: ReservationController/Create
        public async Task<IActionResult> Create(Guid spaceId, Guid userId)
        {
            ViewBag.SpaceId = spaceId;

            var space = await _dbContext.Spaces.FirstOrDefaultAsync(s => s.Id == spaceId);
            var model = new Reservation { Space = space };
            ViewBag.UserId = userId;

            return View(model);
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Reservation model, Guid spaceId, Guid? deskId, Guid? roomId, Guid? parkingId, Guid? userId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var space = await _dbContext.Spaces.FirstOrDefaultAsync(s => s.Id == spaceId);
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
                    
                    if (await _reservationRepository.IsReservationValidAsync(model))
                    {
                        await _reservationRepository.Create(model);
                        return RedirectToAction(nameof(Index), new { Id = model.UserId, spaceId });
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
        public async Task<IActionResult> Edit(Guid id, Guid spaceId)
        {
            ViewBag.SpaceId = spaceId;

            var model = await _reservationRepository.GetByIdAsync(id);
            return View(model);
        }

        // POST: ReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Reservation model, Guid id)
        {
            try
            {
                model.Id = id;
                await _reservationRepository.UpdateAsync(id, model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }

        // GET: ReservationController/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var model = await _reservationRepository.GetByIdAsync(id);
            return View(model);
        }

        // POST: ReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Guid id, Reservation model)
        {
            try
            {
                await _reservationRepository.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
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

