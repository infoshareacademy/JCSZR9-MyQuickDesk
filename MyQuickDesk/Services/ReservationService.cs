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