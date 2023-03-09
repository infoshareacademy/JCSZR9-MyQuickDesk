namespace Loading
{
    public class LoadingFile
    {
        string filePath = "";
        public static Room LoadingFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath)) 
                {
                    int id = int.Parse(reader.ReadLine());
                    string name = reader.ReadLine();
                    int ownerId = int.Parse(reader.ReadLine());
                    bool interactiveBoard = bool.Parse(reader.ReadLine());
                    int capacity = int.Parse(reader.ReadLine());
                    string description = reader.ReadLine();
                    decimal price = decimal.Parse(reader.ReadLine());
                    return new Room (id, name, ownerId, capacity, interactiveBoard, capacity, description, price);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ładownaie pliku nie powiodło się" + ex.Message);
                return null;
            }
            Room room = Room.LoadFromFile(filePath);
        }
    }
}