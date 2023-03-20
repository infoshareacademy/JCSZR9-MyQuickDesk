using Logika_Beznesowa;
using MyQuickDesk.BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuickDesk.Menu
{
    public static class Menu
    {
        public static void UserMenu(Room room)
        {
            while (true)
            {
                Console.WriteLine("1.Dostępne pokoje");
                Console.WriteLine("2.Moje rezerwacje");
                Console.WriteLine("3.Modyfikuj rezerwacje");
                Console.WriteLine("4.Usuń rezerwacje");
                Console.WriteLine("5.Wyjście");


                Console.WriteLine("Wybierz opcję: ");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    RoomsService.DisplayRoomList();
                    Console.ReadKey();
                    Console.Clear();  //Czyści ekran menu
                }
                else if (choose == "2") { }
                else if (choose == "3") { }
                else if (choose == "4") { }
                else if (choose == "5") { break; }
                else { Console.WriteLine("Nieprawidłowa opcja, wybierz ponownie."); }
            }
            
        }

        public static void OwnerMenu(Room room)
        {
            while (true)
            {
                Console.WriteLine("1.Wyświetl moje pokoje");
                Console.WriteLine("2.Dodaj pokój");
                Console.WriteLine("3.Modyfikuj pokój");
                Console.WriteLine("4.Modyfikuj rezerwacje");
                Console.WriteLine("5.Usuń pokój");
                Console.WriteLine("6.Moje rezerwacje");
                Console.WriteLine("7.Modyfikuj rezerwacje");
                Console.WriteLine("8.Usuń rezerwacje");
                Console.WriteLine("9.Wyjście");

                Console.WriteLine("Wybierz opcję: ");
                string choose = Console.ReadLine();
                if (choose == "1") { }
                else if (choose == "2")
                {


                    room.Id = 0; // jeszcze nie znam rozwiązania, natomiast domyślnie będę chciał ustawić tu index na liście, póki co domyślnie jest 0
                    Console.WriteLine("Podaj nazwę pokoju:");
                    room.Name = Console.ReadLine();
                    if (room.Name.Length > 14) { room.Name.Substring(0, 14); }

                    Console.WriteLine("Czy pokój posiada tablice interaktywną?");
                    string ThereIsBoard = Console.ReadLine();
                    if (ThereIsBoard.ToLower() == "y" || ThereIsBoard.ToLower() == "tak" || ThereIsBoard.ToLower() == "t" || ThereIsBoard.ToLower() == "yes")
                    { room.InteractiveBoard = true; }
                    else { room.InteractiveBoard = false; }

                    Console.WriteLine("Maksymalna ilość osób na stanowisku to:");
                    room.Capacity = int.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj krótki opis pokoju (maksymalnie 23 znaki)");
                    room.Description = Console.ReadLine();
                    if (room.Description.Length > 23) { room.Description.Substring(0, 23); }

                    Console.WriteLine("Jaka cena za dzień wynajęcia stanowiska? [PLN]");
                    room.Price = int.Parse(Console.ReadLine());

                    RoomsService.MakeNewRoom(room);
                    Console.Clear();

                }
                else if (choose == "3") { }
                else if (choose == "4") { }
                else if (choose == "5") { }
                else if (choose == "6") { }
                else if (choose == "7") { }
                else if (choose == "8") { }
                else if (choose == "9") { break; }
                else { Console.WriteLine("Nieprawidłowa opcja, wybierz ponownie."); }

            }
            
        }

        //internal static void UserMenu()
        //{
        //    throw new NotImplementedException();
        //}
    }
}