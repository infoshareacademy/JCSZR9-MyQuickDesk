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
                    IsAvaible = true,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now.AddDays(1),
                }
            };

                public List <ParkingSpot> GetAll()
                 {
                    return _parkingspots;
                  }
            
    }
}
