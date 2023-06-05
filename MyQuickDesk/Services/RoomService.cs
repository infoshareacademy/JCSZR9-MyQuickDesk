using MyQuickDesk.Entities;

namespace MyQuickDesk.Services

{

    public class RoomService
    {
        
        private readonly static List<Room> _rooms =
            new List<Room>
            {
                new Room
                {
                Id = Guid.NewGuid(),
                Name = "Sala konferencyjna 1",
                Description="Duza sala konferencyjna",
                MaxCapacity = 50,
               
                },
                  new Room
                {
                Id = Guid.NewGuid(),
                Name = "Sala konferencyjna 2",
                Description="Mala sala konferencyjna",
                MaxCapacity = 10,
                

                },  new Room
                {
                Id = Guid.NewGuid(),
                Name = "Sala konferencyjna 3",
                Description="Srednia sala konferencyjna",
                MaxCapacity = 20,    
                


                },

            };
        public List<Room> GetAll()
        {
            return _rooms;
        }
        public Room GetById(Guid id)
        {
            return _rooms.FirstOrDefault(r => r.Id == id);
        }

        public void Create(Room room)
        {
          //  room.Id = GetNextId();
            _rooms.Add(room);
        }
        public void Update(Room model)
        {
            var room = GetById(model.Id);
            room.Name = model.Name;
            room.MaxCapacity = model.MaxCapacity;
            room.Description = model.Description; 
           

        }
        public void Delete(Guid id)
        {
            _rooms.Remove(GetById(id));
        }
       
    }
}
