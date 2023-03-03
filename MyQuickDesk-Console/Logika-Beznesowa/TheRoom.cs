namespace Logika_Beznesowa
{

    public class TheRoom
    {
        public string name { get; set; }
        public int maxCapacity { get; set; }
        public string description { get; set; }
        public int pricePerDay { get; set; }

        public void Add()
        {
            Console.WriteLine("\nWprowadź nazwe stanowiska: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nWprowadź maksymalną ilość osób na stanowisku: ");
            int maxCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWprowadź opis :");
            string description = Console.ReadLine();

            Console.WriteLine("\nWprowadź cene za dzień roboczy: ");
            int pricePerDay = int.Parse(Console.ReadLine());

            this.name = name;
            this.maxCapacity = maxCapacity;
            this.description = description;
            this.pricePerDay = pricePerDay;
        }


    }
}