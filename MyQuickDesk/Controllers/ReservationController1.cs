using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyQuickDesk.Entities;
using MyQuickDesk.Services;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.ApplicationUser;

namespace MyQuickDesk.Controllers
{
    [Route("api/reservations")]

    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IUserContext _userContext;

        public ReservationController(IReservationService reservationService, IUserContext userContext)
        {
            _reservationService = reservationService;
            _userContext = userContext;

        }
        // GET: ReservationController
        public ActionResult Index()
        {
            var model = _reservationService.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BookInReservation(Reservation reservation)
        {

            try
            {
                if (!_reservationService.IsReservationDateAvailable(reservation.StartTime, reservation.EndTime))
                {
                    return BadRequest("Selected reservation date is not available.");
                }

               _reservationService.BookInReservation(reservation);
                return RedirectToAction("Index", "Reservation");
            }
            catch
            {
                return View();
            }

        }
        [HttpGet]
        [Route("/api/reservations/BookedReservation")]
        public ActionResult GetBookedReservations()
        {
            var reservations = _reservationService.GetBookedReservations();
            return Ok(reservations);
        }

        //[HttpGet("rooms")]
        //public ActionResult GetRoomReservations()
        //{
        //    var roomReservations = _reservationService.GetRoomReservations();
        //    return Ok(roomReservations);
        //}

        //[HttpGet("desks")]
        //public ActionResult GetDeskReservations()
        //{
        //    var deskReservations = _reservationService.GetDeskReservations();
        //    return Ok(deskReservations);
        //}

        //[HttpGet("parkingspots")]
        //public ActionResult GetParkingSpotReservations()
        //{
        //    var parkingSpotReservations = _reservationService.GetParkingSpotsReservations();
        //    return Ok(parkingSpotReservations);
        //}

    }
}
