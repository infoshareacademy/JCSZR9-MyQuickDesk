using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public interface IReservationService
    {
        ICollection<Reservation> GetBookedReservations();
        List<Reservation> GetAll();

    
        void BookInReservation(Reservation reservation);
      
      
        bool IsReservationDateAvailable(DateTime startTime, DateTime endTime);
    }

}
