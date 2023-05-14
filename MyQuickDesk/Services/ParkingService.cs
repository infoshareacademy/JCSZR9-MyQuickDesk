using MyQuickDesk.Models;


namespace MyQuickDesk.Services
{
    public class ParkingService
    {
        private static List<ParkingSpot> _parkingspots =
            new List<ParkingSpot>
            {
                new ParkingSpot
                {
                    Id = 1,
                    FloorName = 'A',
                    PlaceNumber = 1,
                    AccesibleParkingSpot = false,
                    Charger = false,
                    IsAvaible = true,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                }
            };

                public List <ParkingSpot> GetAllAvaible()
                 {
                    return _parkingspots.Where(p=> p.IsAvaible).ToList();
                 }
                public ParkingSpot GetById(int id)
                {
                    return _parkingspots.FirstOrDefault(p => p.Id == id);
                }
            
    }
}
