namespace Loading
{
    public class LoadingFile
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                StreamReader reader = new StreamReader("C:\\Users\\dom\\Downloads\\Rooms.csv");
                line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
                
                reader.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Odczytano plik Rooms.csv");
            }
        }
    }
}