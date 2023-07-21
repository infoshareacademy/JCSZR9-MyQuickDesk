using MyQuickDesk.ApplicationUser;
using MyQuickDesk.DatabaseContext;
using MyQuickDesk.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyQuickDesk.Services
{
    public interface IRoomService
    {
        Task <List<Room>> GetAllAsync();
        Task <Room> GetByIdAsync(Guid id);
        Task Create(Room room);
        Task Update(Room room);
        Task Delete(Guid id);
    }

    public class RoomService : IRoomService
    {

        private readonly MyQuickDeskContext _dbContext;
        private readonly IUserContext _userContext;

        public RoomService(MyQuickDeskContext dbContext, IUserContext userContext)
        {
            _dbContext = dbContext;
            _userContext = userContext;
        }
        public async Task<List<Room>> GetAllAsync()
        {
            return await _dbContext.Rooms.ToListAsync();
        }
        public async Task <Room> GetByIdAsync(Guid id)
        {
            return await _dbContext.Rooms.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task Create(Room room)
        {
            var currentUser = _userContext.GetCurrentUser();
            if (currentUser == null || !currentUser.IsAdmin("Admin"))
            {
                return;
            }

            _dbContext.Rooms.Add(room);
            _dbContext.SaveChanges();
        }
        public async Task <Guid> GetRoomIdAsync()
        {
            var room = await _dbContext.Rooms.FirstOrDefaultAsync();

            if (room != null)
            {
                return room.Id;
            }
            return Guid.Empty;
        }
        public async Task Update(Room room)
        {
            _dbContext.Rooms.Update(room);
            _dbContext.SaveChanges();


        }
        public async Task Delete(Guid id)
        {
            var room = await _dbContext.Rooms.FirstOrDefaultAsync(d => d.Id == id);
            if (room != null)
            {
                _dbContext.Rooms.Remove(room);
                _dbContext.SaveChanges();
            }
        }

    }
}
