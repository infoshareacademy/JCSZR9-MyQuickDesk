
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
        bool Update(Guid Id, Reservation model);
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
            return _dbContext.Reservations.Include(r => r.Space).Include(r => r.User).ToList();
         }

        public Reservation GetById(Guid id)
        {
            return _dbContext.Reservations.Include(r => r.Space).Include(r => r.User).FirstOrDefault(r => r.Id == id);
        }


        public void Create(Reservation reservation)
        {
            var currentUser = _userContext.GetCurrentUser();
            var existingUser = _dbContext.Users.FirstOrDefault(u => u.Id == currentUser.Id);

            if (existingUser != null)
            {
                reservation.User = existingUser;
            }
            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
        }
        public bool IsReservationValid(Reservation reservation)
        {
            var existingReservation = _dbContext.Reservations
                                  .FirstOrDefault(r => r.Id != reservation.Id && r.Space.Id == reservation.Space.Id &&
                                  ((reservation.StartTime >= r.StartTime && reservation.StartTime < r.EndTime) ||
                                  (reservation.EndTime > r.StartTime && reservation.EndTime <= r.EndTime) ||
                                  (reservation.StartTime <= r.StartTime && reservation.EndTime >= r.EndTime)));
        
            return existingReservation == null;
        }


        public bool Update(Guid id, Reservation model)
        {
            var existingReservation = _dbContext.Reservations.FirstOrDefault(r => r.Id == id);

            if (existingReservation == null)
            {
                return false;
            }

            existingReservation.StartTime = model.StartTime;
            existingReservation.EndTime = model.EndTime;
            existingReservation.Space = model.Space;
            if (IsReservationValid(existingReservation))
            {

                _dbContext.Reservations.Update(existingReservation);
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
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