using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IParkingService _parkingService;
        private readonly IRoomService _roomService;
        private readonly IDeskService _deskService;
        private readonly MyQuickDeskContext _dbContext;
    


        public ReservationService(MyQuickDeskContext dbContext, IDeskService deskService, IParkingService parkingService, IRoomService roomService)
        {
            _dbContext = dbContext;
            _deskService = deskService;
            _parkingService = parkingService;
            _roomService = roomService;
           
        }
        public List<Reservation> GetAll()
        {
            return _dbContext.Reservations.ToList();
        }
        public Reservation GetById(Guid id)
        {
            return _dbContext.Reservations.FirstOrDefault(r => r.Id == id);
        }
      
        public void Create(Reservation reservation)
        {
          
            var desk = _deskService.GetById(reservation.DeskId ?? Guid.Empty);
            var room = _roomService.GetById(reservation.RoomId ?? Guid.Empty);
            var parkingSpot = _parkingService.GetById(reservation.ParkingSpotId ?? Guid.Empty);


            reservation.Desk = desk;
            reservation.Room = room;
            reservation.ParkingSpot = parkingSpot;

              _dbContext.Reservations.Add(reservation);
              _dbContext.SaveChanges();
        }



        public void Update(Reservation reservation)
        {
            _dbContext.Reservations.Update(reservation);
            _dbContext.SaveChanges();
        }
        
        public void Delete(Guid id)
        {
            var reservations = _dbContext.Reservations.FirstOrDefault(r => r.Id == id);
            if (reservations != null)
            {
                _dbContext.Reservations.Remove(reservations);
                _dbContext.SaveChanges();
            }
        }
        
    }
}