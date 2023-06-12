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
      
        public ReservationService(MyQuickDeskContext dbContext)
        {
            _dbContext = dbContext;
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
            {
                reservation.Id = Guid.NewGuid();
                var newReservation = new Reservation
                {
                    StartTime = reservation.StartTime,
                    EndTime = reservation.EndTime,
                   
                    Desk = reservation.Desk,
                    DeskId = reservation.DeskId,
                    Room = reservation.Room,
                    RoomId = reservation.RoomId,
                    ParkingSpot = reservation.ParkingSpot,
                    ParkingSpotId = reservation.ParkingSpotId,

                };

                _dbContext.Reservations.Add(newReservation);
                _dbContext.SaveChanges();
            }

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