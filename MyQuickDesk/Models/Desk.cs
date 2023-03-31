namespace MyQuickDesk.Models
{
    public class Desk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
