
using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAll();
        Reservation GetById(Guid id);
        void Create(Reservation reservation);
        void Update(Reservation model);
        void Delete(Guid id);
        bool IsReservationValid(Reservation reservation);

    }
    public class ReservationService : IReservationService
    {
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;
     
        public ReservationService(MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
        }
         public IEnumerable<Reservation> GetAll()
         {
            return _dbContext.Reservations.ToList();
        }

        public Reservation GetById(Guid id)
        {
             return _dbContext.Reservations.FirstOrDefault(r => r.Id == id);
        }


        public void Create(Reservation reservation)
        {
            var currentUser = _userContext.GetCurrentUser();
            reservation.UserId = currentUser.Id;
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
        }
        public bool IsReservationValid(Reservation reservation)
        {
            var existingReservation = _dbContext.Reservations
                .FirstOrDefault(r => r.Space.Id == reservation.Space.Id &&
                                     (reservation.StartTime.Date >= r.StartTime.Date && reservation.StartTime.Date <= r.EndTime.Date ||
                                      reservation.EndTime.Date >= r.StartTime.Date && reservation.EndTime.Date <= r.EndTime.Date ||
                                      reservation.StartTime.Date <= r.StartTime.Date && reservation.EndTime.Date >= r.EndTime.Date));

            return existingReservation == null;
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