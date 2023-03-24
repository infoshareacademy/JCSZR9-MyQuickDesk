using MyQuickDesk.BusinessLogic;
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
                Console.WriteLine("3.Wyjście");


                Console.WriteLine("Wybierz opcję: ");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.Clear();
                    RoomsService.DisplayRoomList(RoomsService.ReadRoomList());
                    Console.ReadKey();
                    Console.Clear();  //Czyści ekran menu
                }
                else if (choose == "2") 
                {
                    Console.Clear();
                    Console.WriteLine("1.Pokaż moje rezerwacje");
                    Console.WriteLine("2.Dodaj nową rezerwacje");
                    Console.WriteLine("3.Modyfikuj rezerwacje");
                    Console.WriteLine("4.Usuń rezerwacje\n");

                    choose = Console.ReadLine();

                    if (choose == "1")
                    {
                        Console.Clear();
                        RoomsService.DisplayRoomList(RoomReservationService.ReservatedRooms());
                        Console.ReadLine();Console.Clear();
                    }
                    else if (choose == "2")
                    { 
                        for (; ; )
                        {
                            Console.Clear();
                            RoomsService.DisplayRoomList(RoomReservationService.NotReservatedRooms());
                            Console.WriteLine("\nKtóry pokój chcesz zarezerwować?\nPodaj nr Id pokoju");
                            int IndexID = int.Parse(Console.ReadLine());
                            RoomReservationService.MakeNewReservation(IndexID);

                           
                            Console.WriteLine("\n\n1.Dodaj nową rezerwacje\n2.Wróc do poprzedniego menu");
                            int i = int.Parse(Console.ReadLine());   Console.Clear();
                            if (i == 2) break;    
                            else if (i != 1 && i != 2) Console.WriteLine("Nieprawidłowa opcja");

                        }


                    }
                    else if (choose == "3")
                    {

                    }

                    else if (choose == "4")
                    {
                        RoomsService.DisplayRoomList(RoomReservationService.ReservatedRooms());
                        Console.WriteLine("\nKtórą zarezerwacje chcesz usunąć?\nPodaj nr Id pokoju");
                        int IndexID = int.Parse(Console.ReadLine());
                        RoomReservationService.DeleteNewReservation(IndexID);

                        Console.WriteLine("\n\n1.Usuń kolejną rezerwacje\n2.Wróc do poprzedniego menu");
                        int i = int.Parse(Console.ReadLine()); Console.Clear();
                        if (i == 2) break;
                        else if (i != 1 && i != 2) Console.WriteLine("Nieprawidłowa opcja");
                    }

                }
                else if (choose == "3") { break; }
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


                    room.Id = Guid.NewGuid(); 
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
//-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static DateTime ChangeDateConsole()
        {
            Console.Clear();
            Console.WriteLine("\nPodaj do kiedy chcesz zarezerwować stanowisko");
            Console.Write("Podaj miesiąc [MM] : ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Podaj dzień [DD] : ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Podaj godzinę: [HH] : ");
            int hour = int.Parse(Console.ReadLine());

            DateTime dateFromConsole = new DateTime(2023, month, day, hour, 00, 00);
            return dateFromConsole;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}