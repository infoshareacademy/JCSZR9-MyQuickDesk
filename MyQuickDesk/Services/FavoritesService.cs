using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public class FavoritesService
    {
            private readonly MyQuickDeskContext _dbContext;
            private readonly IUserContext _userContext;

            public FavoritesService(MyQuickDeskContext dbContext, IUserContext userContext)
            {
                _dbContext = dbContext;
                _userContext = userContext;
            }

            public List<Favorites> GetAll()
            {
                return _dbContext.Favorites.ToList();
            }

            public Favorites GetById(Guid id)
            {
                return _dbContext.Favorites.FirstOrDefault(d => d.UserId == id);
            }

            public void Create(Favorites favorites)
            {

                var currentUser = _userContext.GetCurrentUser();
                if (currentUser == null || !currentUser.IsAdmin("Admin"))
                {
                    return;
                }

                _dbContext.Favorites.Add(favorites);
                _dbContext.SaveChanges();
            }

            public void Update(Favorites favorites)
            {
                _dbContext.Favorites.Update(favorites);
                _dbContext.SaveChanges();
            }

            public void Delete(Guid id)
            {
                var favorites = _dbContext.Favorites.FirstOrDefault(d => d.UserId == id);
                if (favorites != null)
                {
                    _dbContext.Favorites.Remove(favorites);
                    _dbContext.SaveChanges();
                }
            }
        public void AddFavorite(ParkingSpot parkingSpot)
        {
            var currentUser = _userContext.GetCurrentUser();
            var favorites = _dbContext.Favorites.FirstOrDefault(d => d.UserId == currentUser.Id);
            if (favorites != null)
            {
                favorites.ParkingSpot.Add(parkingSpot);
                _dbContext.Favorites.Update(favorites);
            }
            else
            {
                var favorites2 = new Favorites() { UserId = currentUser.Id, ParkingSpot = new List<ParkingSpot> { parkingSpot} };
                _dbContext.Favorites.Add(favorites2);
            }
            _dbContext.SaveChanges();
        }
        
    }
}
