using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.DAL.Repository
{
    public interface IParkingService
    {
        List<ParkingSpot> GetAll();
        ParkingSpot GetById(Guid id);
        void Create(ParkingSpot parkingSpot);
        void Update(ParkingSpot parkingSpot);
        void Delete(Guid id);
    }
    public class ParkingRepository : IParkingService
    {
        private readonly MyQuickDeskContext _dbContext;

        public ParkingRepository(MyQuickDeskContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<ParkingSpot> GetAll()
        {
            return _dbContext.ParkingSpots.ToList();
        }
        public List<ParkingSpot> GetAllAvaible()
        {
            return _dbContext.ParkingSpots.Where(p => p.IsAvaiable).ToList();
        }
        public ParkingSpot GetById(Guid id)
        {
            return _dbContext.ParkingSpots.FirstOrDefault(p => p.Id == id);
        }
        public void Create(ParkingSpot parkingSpot)
        {
            var currentUser = _userContext.GetCurrentUser();
            if (currentUser == null || !currentUser.IsAdmin("Admin"))
            {
                return;
            }

            _dbContext.ParkingSpots.Add(parkingSpot);
            _dbContext.SaveChanges();
        }
       
        public void Update(ParkingSpot parkingSpot)
        {
            _dbContext.ParkingSpots.Update(parkingSpot);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var parkingSpot = _dbContext.ParkingSpots.FirstOrDefault(d => d.Id == id);
            if (parkingSpot != null)
            {
                _dbContext.ParkingSpots.Remove(parkingSpot);
                _dbContext.SaveChanges();
            }
        }
    }
}
