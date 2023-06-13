using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public interface IParkingService
    {
        List<ParkingSpot> GetAll();
        ParkingSpot GetById(Guid id);
        void Create(ParkingSpot parkingSpot);
        void Update(ParkingSpot parkingSpot);
        void Delete(Guid id);
        Guid GetParkingSpotId();
    }
}
