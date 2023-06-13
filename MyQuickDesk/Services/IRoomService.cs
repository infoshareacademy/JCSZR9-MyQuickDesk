using MyQuickDesk.Entities;

namespace MyQuickDesk.Services
{
    public interface IRoomService
    {
        List<Room> GetAll();
        Room GetById(Guid id);
        void Create(Room room);
        void Update(Room room);
        void Delete(Guid id);
        Guid GetRoomId();

    }
}
