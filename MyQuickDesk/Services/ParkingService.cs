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
                    IsAvaiable = true,
                   
                    
                }
            };

                public List <ParkingSpot> GetAllAvaible()
                 {
                    return _parkingspots.Where(p=> p.IsAvaiable).ToList();
                 }
                public ParkingSpot GetById(Guid id)
                {
                    return _parkingspots.FirstOrDefault(p => p.Id == id);
                }
            
    }
}
