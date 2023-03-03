using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logika_Beznesowa
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public bool InteractiveBoard { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Room(int id, string name, int ownerId, bool interactiveBoard, int capacity, string description, decimal price)
        {
            Id = id;
            Name = name;
            OwnerId = ownerId;
            InteractiveBoard = interactiveBoard;
            Capacity = capacity;
            Description = description;
            Price = price;
        }

        public static Room Add(int id, string name, int ownerId, bool interactiveBoard, int capacity, string description, decimal price)
        {
            Room newRoom = new Room(id, name, ownerId, interactiveBoard, capacity, description, price);
            return newRoom;
        }

        public static Room Modify(Room room, string name, bool interactiveBoard, int capacity, string description, decimal price)
        {
            room.Name = name;
            room.InteractiveBoard = interactiveBoard;
            room.Capacity = capacity;
            room.Description = description;
            room.Price = price;
            return room;
        }

        public static void Delete(int id)
        {
        }
    }
}
