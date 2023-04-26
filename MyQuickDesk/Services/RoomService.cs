using MyQuickDesk.Models;
namespace MyQuickDesk.Services

{

    public class RoomService
    {
        private static int _idCounter = 3;
        private readonly static List<Room> _rooms =
            new List<Room>
            {
                new Room
                {
                Id = 1,
                Name = "Sala konferencyjna 1",
                Description="Duza sala konferencyjna",
                InteractiveBoard = true,
                MaxCapacity = 50,
                StartDate= DateTime.Now,
                EndDate= DateTime.Now,

                },
                  new Room
                {
                Id = 2,
                Name = "Sala konferencyjna 2",
                Description="Mala sala konferencyjna",
                InteractiveBoard = true,
                MaxCapacity = 10,
                StartDate= DateTime.Now,
                EndDate= DateTime.Now,

                },  new Room
                {
                Id = 3,
                Name = "Sala konferencyjna 3",
                Description="Srednia sala konferencyjna",
                InteractiveBoard = true,
                MaxCapacity = 20,    
                StartDate= DateTime.Now,
                EndDate= DateTime.Now,

                },

            };
        public List<Room> GetAll()
        {
            return _rooms;
        }
        public Room GetById(int id)
        {
            return _rooms.FirstOrDefault(r => r.Id == id);
        }

        public void Create(Room room)
        {
            room.Id = GetNextId();
            _rooms.Add(room);
        }
        public void Update(Room model)
        {
            var room = GetById(model.Id);
            room.Name = model.Name;
            room.InteractiveBoard = model.InteractiveBoard;
            room.MaxCapacity = model.MaxCapacity;
            room.Description = model.Description; 
            room.EndDate = model.EndDate;
            room.StartDate = model.StartDate;

        }
        public void Delete(int id)
        {
            _rooms.Remove(GetById(id));
        }
        private int GetNextId()
        {
            _idCounter++;
             return _idCounter;
        }
    }
}
