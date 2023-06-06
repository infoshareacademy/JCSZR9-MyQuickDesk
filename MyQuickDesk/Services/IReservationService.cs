using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public interface IReservationService
    {
        List<Reservation> GetRoomReservations();
        List<Reservation> GetDeskReservations();
        List<Reservation> GetParkingSpotsReservations();
        ICollection<Reservation> GetBookedReservations();
        List<Reservation> GetAll();
        void BookInReservation(Reservation reservation);
        bool IsReservationDateAvailable(DateTime startTime, DateTime endTime);
    }

}
