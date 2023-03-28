﻿namespace MyQuickDesk.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OwnerId { get; set; }
        public bool InteractiveBoard { get; set; }
        public int MaxCapacity { get; set; }
        public int price { get; set; }
    }
}