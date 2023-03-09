namespace Loading
{
    public class LoadingFile
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Rooms.csv");

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] parts = line.Split('|');

                if (parts[0] == "Room")
                {
                    Room room = new Room();
                    room.RoomNumber = parts[1];
                    room.SquareFeet = double.Parse(parts[2]);
                    rooms.Add(room);
                }

                else if (parts[0] == "Tenant")
                {
                    Tenant tenant = new Tenant();
                    tenant.Name = parts[1];
                    tenant.PhoneNumber = parts[2];
                    tenants.Add(tenant);
                }

                else if (parts[0] == "Owner")
                {
                    Owner owner = new Owner();
                    owner.Name = parts[1];
                    owner.PhoneNumber = parts[2];
                    owners.Add(owner);
                }
            }

            reader.Close();
        }
    }
}