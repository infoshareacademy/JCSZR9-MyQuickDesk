using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;

namespace MyQuickDesk.Services

{

    public class RoomService
    {

        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;

        public RoomService(MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
        }
        public List<Room> GetAll()
        {
            return _dbContext.Rooms.ToList();
        }
        public Room GetById(Guid id)
        {
            return _dbContext.Rooms.FirstOrDefault(r => r.Id == id);
        }

        public void Create(Room room)
        {
            var currentUser = _userContext.GetCurrentUser();
            if (currentUser == null || !currentUser.IsAdmin("Admin"))
            {
                return;
            }

            _dbContext.Rooms.Add(room);
            room.CreatedById = currentUser.Id;
            _dbContext.SaveChanges();
        }
        public void Update(Room room)
        {
            _dbContext.Rooms.Update(room);
            _dbContext.SaveChanges();


        }
        public void Delete(Guid id)
        {
            var room = _dbContext.Rooms.FirstOrDefault(d => d.Id == id);
            if (room != null)
            {
                _dbContext.Rooms.Remove(room);
                _dbContext.SaveChanges();
            }
        }

    }
}
