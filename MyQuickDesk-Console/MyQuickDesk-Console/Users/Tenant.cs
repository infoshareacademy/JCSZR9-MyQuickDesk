using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuickDesk_Console.Users
{
    internal class Tenant : User
    {
        public Tenant(int id, string username, string firstname, string lastname, string password, string role, string email) : base(id, username, firstname, lastname, password, role, email)
        { }

        public void AvaibleRooms(Logika_Beznesowa.TheRoom room)
        {
            //Sprawdź dostępne pokoje
        }
        public void MyReservations(Reservation reservation)
        {
            // Sprawdź moje rezerwacje
        }
        public void AddReservation(Reservation reservation)
        {
            // dodanie rezerwacji do listy rezerwacji
        }

        public void ModifyReservation(Reservation reservation)
        {
            // modyfikacja istniejącej rezerwacji
        }

        public void DeleteReservation(Reservation reservation)
        {
            // usunięcie rezerwacji z listy rezerwacji
        }
    }
