using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public interface IReservationService
    {
        List<Reservation> GetAll();
        Reservation GetById(Guid id);
        void Create(Reservation reservation);
        void Update(Reservation model);
        void Delete(Guid id);
       
    }

}
