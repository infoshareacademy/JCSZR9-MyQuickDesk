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
        public ActionResult Index(Guid id, Guid spaceId)
        {
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
        public ActionResult Create(Guid spaceId,Guid userId)
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
        public ActionResult Create(Reservation model, Guid spaceId, Guid? deskId, Guid? roomId, Guid? parkingId,Guid? userId)
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
                        return RedirectToAction(nameof(Index));
                   }
                   else
                   {
                      ModelState.AddModelError(string.Empty, "The reservation conflicts with existing bookings. Please choose a different time slot.");
                   }
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
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
                _reservationService.Update(id,model);
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
        //[HttpPut]
        //public ActionResult Update(Reservation model, Guid Id)
        //{
        //    if(!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var isUpdate = _reservationService.Update(Id, model);
        //    if (!isUpdate)
        //    {
        //        return NotFound();
        //    }
        //    return View(model);
        //}
    }
}

