using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Net.Sockets;
using System.Linq;
using System.Diagnostics;
using System.Xml.Linq;
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
using MyQuickDesk.BussinessLogic;

namespace Logika_Beznesowa
{

    public class RoomInfoClassMap : ClassMap<Room>
    //dziedziczy z klasy generycznej ClassMap<T>, aby umożliwić mapowanie do pliku
    {
        public RoomInfoClassMap()
        {
            // Mapuj(wyrażenie lambda) na nazwe ("Nazwa kolumny");
            Map(r => r.Id).Name("Id");
            Map(r => r.Name).Name("Name");
            Map(r => r.OwnerId).Name("Owner Id");
            Map(r => r.InteractiveBoard).Name("Interactive Board");
            Map(r => r.Capacity).Name("Max Capacity");
            Map(r => r.Description).Name("Short Description");
            Map(r => r.Price).Name("Price [PLN]");
        }
    }

    public class RoomsService
    {


        //Stworzenie uniwersalnej ścieżki do pliku, za pomocą Path.Combine()
        static string csvPath = Path.Combine(Environment.CurrentDirectory, "..\\..\\..\\AppData\\rooms.csv");
        static public void MakeNewRoom(Room room)
        {
            //using służy do automatycznego usuwania metod (przestrzeń tymczasowa).
            //Raz otwarty plik przez program pozostaje otwarty, więc trzeba go zamknąć,
            //albo za pomocą metody .Close(), albo zawierając wszystko w przestrzeni tymczasowej
            using (var streamWriter = new StreamWriter(csvPath, append: true)) //stwórz i/lub otwórz (do zapisu) plik
            {
                bool Header = false; // domyślnie kolumny są włączone

                if (!File.Exists(csvPath) || new FileInfo(csvPath).Length == 0)
                {
                    Header = true;        /* Jeżeli plik istnieje, ustaw wklejanie nazw kolumn   */
                    // string[] headers = { "Id", "Name", "Owner Id", "Interactive Board", "Max Capacity", "Short Description", "Price [PLN]" };
                    // streamWriter.WriteLine(string.Join(",", headers));
                }
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)  // stwórz kopie klasy, aby móc zmienić element
                { HasHeaderRecord = Header };                     // włącz/wyłącz nagłówek kolumn

                using (var csvWriter = new CsvWriter(streamWriter, configuration)) //zapisz
                {


                    var rooms = Room.Add(room); //tymczasowa metoda
                    csvWriter.Context.RegisterClassMap<RoomInfoClassMap>();
                    csvWriter.WriteRecords(rooms); // zapisz do pliku
                }
            }
        }
        static public List<Room> ReadRoomList()
        {
            using (var streamReader = new StreamReader(csvPath))
            {
                // Tworzymy obiekt CsvReader z pliku CSV, korzystając z biblioteki CsvHelper.
                // Do CsvReadera przekazujemy strumień odczytu oraz kulturę dla pliku CSV.
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    // Rejestrujemy klasę mapowania RoomInfoClassMap dla CsvReadera.
                    // Ta klasa mapuje właściwości klasy Room na kolumny pliku CSV.
                    csvReader.Context.RegisterClassMap<RoomInfoClassMap>();

                    // Pobieramy sekwencję rekordów z pliku CSV i mapujemy je na obiekty klasy Room.
                    // Następnie zwracamy wynik jako listę obiektów klasy Room.
                    return csvReader.GetRecords<Room>().ToList();
                }
            }
        }
        static public void DisplayRoomList()
        {
            int i = 1;
            var rooms = ReadRoomList();
            string header = string.Format($"{"Room ID",-7} | {"Name",-14} | {"Owner ID",-8} | {"Inter. Board",-12} | {"Max Capacity",-12} | {"Description",-23} | {"Price [PLN]",-11} |\n" +
                                        $"--------------------------------------------------------------------------------------------------------");
            Console.WriteLine(header);

            foreach (var room in rooms)
            {

                string list = string.Format($"{i,-7} | {room.Name,-14} | {room.OwnerId,-8} | {room.InteractiveBoard,-12} | {room.Capacity,-12} | {room.Description.Substring(0, 22),-23} | {room.Price,-11} |");
                i++;
                Console.WriteLine(list); // nie znalazłem sposobu aby nie użyć w tej pętli CW. Natomiast odseparowałem to aby móc w przyszłości użyć tego w inny sposób
            }
        }
        
        static public void DisplayRoomListForOwner()
        {
            var rooms = ReadRoomList();

            var OwnerRooms = rooms.Where(room => room.OwnerId == 0);

            int i = 1;
            string header = string.Format($"{"Room ID",-7} | {"Name",-14} | {"Owner ID",-8} | {"Inter. Board",-12} | {"Max Capacity",-12} | {"Description",-23} | {"Price [PLN]",-11} |\n" +
                                            $"--------------------------------------------------------------------------------------------------------");
            Console.WriteLine(header);

            foreach (var room in OwnerRooms)
            {
                int maxLength = Math.Min(23, room.Description.Length); //stworzyłem Math.Min, bo przy krótszej nazwie pokojów wyskakiwał mi ArgumentOutOfRangeException
                string list = string.Format($"{i,-7} | {room.Name,-14} | {room.OwnerId,-8} | {room.InteractiveBoard,-12} | {room.Capacity,-12} | {room.Description.Substring(0, maxLength),-23} | {room.Price,-11} |");
                i++;
                Console.WriteLine(list);
            }
        }


    }
}