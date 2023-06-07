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

        private readonly IDeskService _deskService;

        public ReservationController(IReservationService reservationService, IDeskService deskService)
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult BookInReservation(Reservation reservation)
        {
            try
            {
                if (!_reservationService.IsReservationDateAvailable(reservation.StartTime, reservation.EndTime))
                {
                    return BadRequest("Selected reservation date is not available.");
                }

                _deskService.BookReservationForDesk(reservation, (Guid)reservation.DeskId);
                var desks = _deskService.GetAll();
                return View("Index",desks);
            }
            catch
            {
                return View();
            }

        }
        //[HttpGet("desks")]
        //public ActionResult GetDeskReservations()
        //{
        //    var deskReservations = _reservationService.GetDeskReservations();
        //    return Ok(deskReservations);
        //}


        //[HttpGet("rooms")]
        //public ActionResult GetRoomReservations()
        //{
        //    var roomReservations = _reservationService.GetRoomReservations();
        //    return Ok(roomReservations);
        //}



        //[HttpGet("parkingspots")]
        //public ActionResult GetParkingSpotReservations()
        //{
        //    var parkingSpotReservations = _reservationService.GetParkingSpotsReservations();
        //    return Ok(parkingSpotReservations);
        //}


    }
}
