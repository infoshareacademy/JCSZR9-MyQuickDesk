using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public class ParkingService
    {
        private static List<ParkingSpot> _parkingspots =
            new List<ParkingSpot>
            {
                new ParkingSpot
                {
                    Id = Guid.NewGuid(),
                    Description ="First flour",
                    Name= "A",
                    HandicappedSpot = false,
                    Charger = false,
                    IsAvaible = true,
                   
                    
                }
            };

                public List <ParkingSpot> GetAllAvaible()
                 {
                    return _parkingspots.Where(p=> p.IsAvaible).ToList();
                 }
                public ParkingSpot GetById(Guid id)
                {
                    return _parkingspots.FirstOrDefault(p => p.Id == id);
                }

    }
}
