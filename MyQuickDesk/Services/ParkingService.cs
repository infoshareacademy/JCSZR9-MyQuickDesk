using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public class ParkingService : IParkingService
    {
        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;
        public ParkingService(MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
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
            parkingSpot.CreatedById = currentUser.Id;
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
