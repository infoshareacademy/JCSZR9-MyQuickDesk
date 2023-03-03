namespace diana_kosel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true) 
            {
                Console.WriteLine("1.Jestem użytkownikiem");
                Console.WriteLine("2.Jestem wyjnajmującym");

                Console.WriteLine("Wybierz opcję: ");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    UserMenu();
                }
                else if (choose == "2") 
                {
                    OwnerMenu();
                }
                else 
                {
                    Console.WriteLine("Nieprawidłowa opcja! Wybierz ponownie.");
                }
            }
        }
        static void UserMenu()
        {
            Console.WriteLine("1.Dostępne pokoje");
            Console.WriteLine("2.Moje rezerwacje");
            Console.WriteLine("3.Modyfikuj rezerwacje");
            Console.WriteLine("4.Usuń rezerwacje");
            Console.WriteLine("5.Powrót");
           

            Console.WriteLine("Wybierz opcję: ");
            string choose = Console.ReadLine();
            if (choose == "1") 
            {
            }
            else if (choose == "2") 
            { 
            }
            else if (choose == "3")
            {
            }
            else if (choose == "4")
            {
            }
            else if (choose == "5")
            {
            }
            else 
            {
                Console.WriteLine("Nieprawidłowa opcja, wybierz ponownie.");
            }
        }
        static void OwnerMenu()
        {
            Console.WriteLine("1.Wyświetl moje pokoje");
            Console.WriteLine("2.Dodaj pokój");
            Console.WriteLine("3.Modyfikuj pokój");
            Console.WriteLine("4.Modyfikuj rezerwacje");
            Console.WriteLine("5.Usuń pokój");
            Console.WriteLine("6.Moje rezerwacje");
            Console.WriteLine("7.Modyfikuj rezerwacje");
            Console.WriteLine("8.Usuń rezerwacje");
            Console.WriteLine("9.Powrót");
           
            Console.WriteLine("Wybierz opcję: ");
            string choose = Console.ReadLine();
            if (choose == "1")
            {
            }
            else if (choose == "2")
            {
            }
            else if (choose == "3")
            {
            }
            else if (choose == "4")
            {
            }
            else if (choose == "5")
            {
            }
            else if (choose == "6")
            {
            }
            else if (choose == "7")
            {
            }
            else if (choose == "8")
            {
            }
            else if (choose == "9")
            {
            }
            else
            {
                Console.WriteLine("Nieprawidłowa opcja, wybierz ponownie.");
            }
        }
    }
}
