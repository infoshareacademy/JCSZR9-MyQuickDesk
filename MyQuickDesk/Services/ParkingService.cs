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
                    Description ="First floor",
                    Name= "A",
                    HandicappedSpot = false,
                    Charger = false,
                    IsAvaible = true,
                   
                    
                }
            };
        private Guid _idCounter;

        public List<ParkingSpot> GetAllAvaible()
        {
            return _parkingspots.Where(p => p.IsAvaible).ToList();
        }

        public ParkingSpot GetById(Guid id)
        {
            return _parkingspots.FirstOrDefault(p => p.Id == id);
        }

        public void Create(ParkingSpot spot)
        {
            spot.Id = GetNextId();
            _parkingspots.Add(spot);
        }

        public void Update(ParkingSpot spot)
        {
            var existingSpot = GetById(spot.Id);

            existingSpot.Description = spot.Description;
            existingSpot.Name = spot.Name;
            existingSpot.HandicappedSpot = spot.HandicappedSpot;
            existingSpot.Charger = spot.Charger;
            existingSpot.IsAvaible = spot.IsAvaible;
        }

        public void Delete(Guid id)
        {
            _parkingspots.Remove(GetById(id));
        }

        private Guid GetNextId()
        {
            _idCounter = Guid.NewGuid();

            return _idCounter;
        }
    }
}
