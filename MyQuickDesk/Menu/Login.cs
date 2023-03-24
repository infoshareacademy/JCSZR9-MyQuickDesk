using System;
using System.Text.RegularExpressions;
using MyQuickDesk.BussinessLogic;

public class Login
    
{
    public static void LoginToSystem()
    {
        while (true)
        {
            Styles.Cyan("Wprowadź swoje dane logowania:\n\n");

            Styles.Cyan("Login: ");
            var login = Console.ReadLine();
            Styles.Cyan("Hasło: ");
            var password = Console.ReadLine();


            var user = ValidateUser(login, password);
            if (user != null)
            {
                if (user.Type == "user")
                {
                    Console.Clear();
                    Console.WriteLine("Witaj user");
                    UserMenu.Show(user.Id, user.Login);
                    break;
                }
                else if (user.Type == "owner")
                {
                    Console.Clear();
                    Console.WriteLine("Witaj owner!");
                    OwnerMenu.Show(user.Id, user.Login);
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

    static User ValidateUser(string Login, string Password)
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

        var user = users.FirstOrDefault(u => u.Login == Login && u.Password == Password);
        return user;
    }

    public static void Registration()
    {

        while(true)
        {
            Styles.MainLogo();
            Console.SetCursorPosition(0, 15);
            Styles.Cyan("Nazwa użytkownika: ");
            string newLogin = Console.ReadLine();

            if (CheckLoginExists(newLogin))
            {
                Styles.Red("Użytkownik o takim loginie już istnieje.\n");
                Console.ReadKey();

            }

            else
            {

                Styles.Yellow("Hasło musi mieć min. 10 znaków (min. jedna duża litera, jedna cyfra i jeden znak specjalny)");
                Styles.Cyan("Hasło: ");
                string newPassword = Console.ReadLine();

                Styles.Cyan("Hasło(powtórz): ");
                string checkNewPassword = Console.ReadLine();

                if (!IsPasswordValid(newPassword))
                {
                    Styles.Red("Hasło nie spełnia wymagań (min. 10 znaków, jedna duża litera, jedna cyfra i jeden znak specjalny)\n");
                    Console.ReadKey();
                }

                else
                {

                    if (newPassword == checkNewPassword)
                    {
                        while (true)
                        {
                            Console.WriteLine("\n");
                            Styles.Cyan("Jakie konto chcesz utworzyć?\n");
                            Styles.Yellow("Jeśli jesteś właścicielem biurek/salek wybierz 1 i naciśnij enter.\n");
                            Styles.Yellow("Jeśli jesteś osobą która chce wynająć biurko albo pomieszczenie wybierz 2 i naciśnij enter.\n");

                            string userAnswer = Console.ReadLine();

                            if (int.TryParse(userAnswer, out int answer))
                            {

                                if (answer == 1 || answer == 2)
                                {
                                    if (answer == 1)
                                    {
                                        string userType = "owner";
                                        AddUser(newLogin, newPassword, userType);
                                        Styles.Cyan("Użytkownik został zarejestrowany.");
                                        Thread.Sleep(1500);
                                        return;

                                    }
                                    else
                                    {
                                        string userType = "user";
                                        AddUser(newLogin, newPassword, userType);
                                        Styles.Cyan("Użytkownik został zarejestrowany.");
                                        Thread.Sleep(1500);
                                        return;
                                    }
                                }

                            }

                            Styles.Red("Musisz wybrać 1 lub 2");
                            Console.ReadKey();
                        }

                    }
                    else
                    {
                        Styles.Red("Hasła nie są takie same!\n");
                        Thread.Sleep(1500);
                    }

                }
            }
            Console.Clear();

        }
        
    }

    static bool CheckLoginExists(string login)
    {
        string path = Path.Combine("..\\..\\..\\AppData\\users.csv"); ;
        if (!File.Exists(path))
        {

            Styles.Red("Błąd połączenia z bazą danych!");
            return false;
        }

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split(",");
                if (fields.Length >= 2 && fields[1] == login.ToLower())
                {
                    return true;
                }
            }

            return false;
        }
    }


    static bool IsPasswordValid(string password)
    {
        return password.Length >= 10 && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "\\d") && Regex.IsMatch(password, "\\W");
    }

    static void AddUser (string login, string password, string userType)
    {
        string path = Path.Combine("..\\..\\..\\AppData\\users.csv");

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine($"{GuidGenerator()},{login},{password},{userType}");
        }
    }

    static string GuidGenerator()
    {
        Guid guid = Guid.NewGuid();
        string newGuid = guid.ToString();
        return newGuid;
    }
}