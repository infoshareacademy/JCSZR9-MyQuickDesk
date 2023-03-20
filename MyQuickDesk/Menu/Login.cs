using CsvHelper;
using MyQuickDesk.BussinessLogic;
using MyQuickDesk.Menu;
using System;
using System.IO;
using System.Linq;
using System.Text;


public class Login
{
    public static void Data(Room room)
    {
        while (true)
        {
            Console.WriteLine("Wprowadź swoje dane logowania:");
            Console.Write("Login: ");
            var login = Console.ReadLine();
            Console.Write("Hasło: ");
            var password = Console.ReadLine();

            var user = ValidateUser(login, password);
            if (user != null)
            {
                if (user.Type == "user")
                {
                    Console.Clear();
                    Menu.UserMenu(room);
                    break;
                }
                else if (user.Type == "tenant")
                {
                    Console.Clear();
                    Menu.OwnerMenu(room);
                    break;
                }
                else
                {
                    Console.WriteLine("Przykro mi nie masz uprawnień żeby wyświetlić to menu");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowa nazwa użytkownika lub hasło.");
            }
            Console.ReadLine();

            Console.Clear();
        }
    }


    static User ValidateUser(string login, string password)
    {

        string csvFile = Path.Combine("..\\..\\..\\AppData\\users.csv");


        if (!File.Exists(csvFile))
        {
            Console.WriteLine("Plik użytkowników nie został znaleziony.");
            return null;
        }

        var lines = File.ReadAllLines(csvFile);
        var users = lines.Select(line => line.Split(','))
                            .Select(parts => new User { Id = parts[0], Login = parts[1], Password = parts[2], Type = parts[3] });

        var user = users.FirstOrDefault(u => u.Login == login && u.Password == password);
        return user;
    }
}
