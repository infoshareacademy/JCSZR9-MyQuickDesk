using Microsoft.EntityFrameworkCore;
using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public class ReservationService : IReservationService
    {
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;

        public ReservationService(MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;

        }
        public List<Reservation> GetAll()
        {
            return _dbContext.Reservations.ToList();
        }


        public ICollection<Reservation> GetBookedReservations()
        {
            return _dbContext.Reservations.ToList();

        }
        

        public void BookInReservation(Reservation reservation)
        {

            _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();

        }

        public bool IsReservationDateAvailable(DateTime startTime, DateTime endTime)
        {
            ICollection<Reservation> bookedReservations = GetBookedReservations();


            foreach (var reservation in bookedReservations)
            {
                if ((startTime.Date >= reservation.StartTime.Date && startTime.Date <= reservation.EndTime.Date) ||
            (endTime.Date >= reservation.StartTime.Date && endTime.Date <= reservation.EndTime.Date) ||
            (startTime.Date <= reservation.StartTime.Date && endTime.Date >= reservation.EndTime.Date))
                {
                    return false;
                }

            }
            return true;
        }
         
    }
}