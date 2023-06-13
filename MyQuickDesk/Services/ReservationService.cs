using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public class ReservationService : IReservationService
    {
        
        private readonly MyQuickDeskContext _dbContext;
        private readonly IRoomService _roomService;
        private readonly IDeskService _deskService;
        private readonly IParkingService _parkingService;


        public ReservationService(MyQuickDeskContext dbContext, IRoomService roomService, IDeskService deskService, IParkingService parkingService)
        {
            _dbContext = dbContext;
            _roomService = roomService;
            _deskService = deskService;
            _parkingService = parkingService;   
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
            //reservation.RoomId = GetRoomId();
            reservation.DeskId = GetDeskId();
           // reservation.ParkingSpotId = GetParkingSpotId();
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            

        }

        private Guid? GetParkingSpotId()
        {
            Guid parkingSpotId = _parkingService.GetParkingSpotId();
            return parkingSpotId;
        }

        private Guid? GetDeskId()
        {
            Guid deskId = _deskService.GetDeskId();
            return deskId;
        }

        private Guid? GetRoomId()
        {
            Guid roomId = _roomService.GetRoomId();
            return roomId;
            
        }

        public void Update(Reservation reservation)
        { 
           
                _dbContext.SaveChanges(); 
                _dbContext.Reservations.Update(reservation);

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