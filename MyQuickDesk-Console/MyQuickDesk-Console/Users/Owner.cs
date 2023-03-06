using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users.Users
{
    public class Owner : User
    {
        public Owner(int id, string username, string firstname, string lastname, string password, string role, string email) : base(id, username, firstname, lastname, password, role, email)
        { }
        private static void AddRoom(Logika_Beznesowa.TheRoom room)
        {
            // dodanie pokoju do bazy danych lub listy pokoi
        }

        public void ModifyRoom(Logika_Beznesowa.TheRoom room)
        {
            // modyfikacja istniejącego pokoju
        }

        public void DeleteRoom(Logika_Beznesowa.TheRoom room)
        {
            // usunięcie pokoju z bazy danych lub listy pokoi
        }

        public void AddReservation(Reservation reservation)
        {
            // dodanie rezerwacji do bazy danych lub listy rezerwacji
        }

        public void ModifyReservation(Reservation reservation)
        {
            // modyfikacja istniejącej rezerwacji
        }

        public void DeleteReservation(Reservation reservation)
        {
            // usunięcie rezerwacji z bazy danych lub listy rezerwacji
        }

        public List<Room> GetMyRooms()
        {
            // pobranie wszystkich pokoi, które należą do właściciela
        }

        public List<Reservation> GetMyReservations()
        {
            // pobranie wszystkich rezerwacji, które zostały dokonane przez właściciela
        }

    }
}