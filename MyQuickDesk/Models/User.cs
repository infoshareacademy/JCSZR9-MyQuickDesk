namespace MyQuickDesk.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public int ReservationId { get; set; }  
        public string Password { get; set; }
        public string Name { get; set; }
        public bool Owner { get; set; }
        public string Email { get; set; }

        public Reservation? Reservation { get; set; }    
    }

}
