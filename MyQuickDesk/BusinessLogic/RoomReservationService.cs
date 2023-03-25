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



namespace MyQuickDesk.BusinessLogic
{
    public class RoomReservationService
    {

        static public void MakeNewFile(List<Room> RoomList)
        {
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




        static public void MakeNewRoom()
        {

        }
        //static public string ShowMyReservations()  
        //{



        //    return string.Format("");    
        //}
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //                                              Modyfikacja pliku
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        static public void MakeNewReservation(int Index, string Reservated)
        {
            var RoomList = RoomsService.ReadRoomList();
            DateTime NewDate;
            string CompareId;

            int i = 1;
            foreach (var room in selectedRooms)
            {

                if (i == Index)
                {
                    NewDate = Menu.ChangeDateConsole();

                    room.ReservationDate = NewDate;
                    CompareId = room.Id;

                    foreach (var room1 in RoomList)
                    {
                        if (room1.Id == CompareId)
                        {
                            room1.ReservationDate = NewDate;
                        }
                    }
                    break;
                }
                i++;
            }
            MakeNewFile(RoomList);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        static public void DeleteNewReservation(int Index)
        {
            var RoomList = RoomsService.ReadRoomList();
            DateTime NewDate;
            string CompareId;

            int i = 1;
            foreach (var room in ReservatedRooms())
            {

                if (i == Index)
                {
                    NewDate = DateTime.Now.AddDays(-1);

                    room.ReservationDate = NewDate;
                    CompareId = room.Id;

                    foreach (var room1 in RoomList)
                    {
                        if (room1.Id == CompareId)
                        {
                            room1.ReservationDate = NewDate;
                        }
                    }
                    break;
                }
                i++;
            }
            MakeNewFile(RoomList);
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
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