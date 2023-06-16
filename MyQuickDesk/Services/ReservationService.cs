
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
        public bool IsReservationValid(Reservation reservation)
        {
            ICollection<Reservation>Reservations = _dbContext.Reservations
                .Where(r => r.Id == reservation.Id)
                .ToList();

            foreach (var reservations in Reservations)
            {
                if ((reservation.StartTime.Date >= reservation.StartTime.Date && reservation.StartTime.Date <= reservation.EndTime.Date) ||
                    (reservation.EndTime.Date >= reservation.StartTime.Date && reservation.EndTime.Date <= reservation.EndTime.Date) ||
                    (reservation.StartTime.Date <= reservation.StartTime.Date && reservation.EndTime.Date >= reservation.EndTime.Date))
                {
                    return false;
                }
            }

            return true;
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