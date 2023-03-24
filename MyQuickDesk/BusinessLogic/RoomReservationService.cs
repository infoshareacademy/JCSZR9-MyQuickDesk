using MyQuickDesk.BussinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.Reflection.PortableExecutable;
using MyQuickDesk.Menu;

namespace MyQuickDesk.BusinessLogic
{
    public class RoomReservationService
    {

        static public void MakeNewFile(Room room)
        {
            var RoomList = RoomsService.ReadRoomList();
            using (var streamWriter = new StreamWriter(RoomsService.csvPath, append: false)) //nadpisz istniejący plik
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)  // stwórz kopie klasy, aby móc zmienić element
                { HasHeaderRecord = true };                     // włącz nagłówek kolumn
                using (var csvWriter = new CsvWriter(streamWriter, configuration)) //zapisz
                {
                    csvWriter.Context.RegisterClassMap<RoomInfoClassMap>();
                    csvWriter.WriteRecords(RoomList);           // zapisz do pliku
                }
            }
        }
        static public string ShowMyReservations()  
        {

            

            return string.Format("");    
        }

        static public void MakeNewReservation(int Index)
        {
            int i = 1;
            foreach (var room in NotReservatedRooms())
            {
                if (i == Index)
                {
                    var NewDate = Menu.Menu.ChangeDateConsole();
                    
                    room.ReservationDate = NewDate;
                    break;
                }
                i++;
            }

        }

        static public List<Room> NotReservatedRooms()
        {
            var RoomList = RoomsService.ReadRoomList(); // pobierz liste pokoi

            List<Room> not_Res_Rooms = new List<Room>();

            foreach (var room in RoomList)
            {
                if (room.ReservationDate <= DateTime.Now) 
                { 
                    not_Res_Rooms.Add(room);
                }
            }
            return not_Res_Rooms;
        }

        static public List<Room> ReservatedRooms()
        {
            var RoomList = RoomsService.ReadRoomList(); // pobierz liste pokoi

            List<Room> Res_Rooms = new List<Room>();

            foreach (var room in RoomList)
            {
                if (room.ReservationDate > DateTime.Now)
                {
                    Res_Rooms.Add(room);
                }
            }
            return Res_Rooms;
        }
    }
}
