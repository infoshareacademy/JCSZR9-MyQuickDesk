using System;
using MyQuickDesk.BusinessLogic;
using MyQuickDesk.BussinessLogic;

public class OwnerMenu
{
    public static void Show(string Id, string Login)
    {
        string[] options = { "1. Wyświetl moje pokoje ", "2. Dodaj pokój ", "3. Modyfikuj pokój ", "4. Modyfikuj rezerwację ", "5. Usuń pokój ", "6. Moje rezerwacje ", "7. Modyfikuj rezerwację ", "8. Usuń rezerwację ", "9. Wyloguj się " };

        int selectedIndex = 0;

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            Styles.WidgetBar(Id, Login);
            Console.SetCursorPosition(0, 8);

            Menu.Move(options, selectedIndex, Id, Login);

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex--;
                    if (selectedIndex < 0)
                    {
                        selectedIndex = options.Length - 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex++;
                    if (selectedIndex == options.Length)
                    {
                        selectedIndex = 0;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (selectedIndex == options.Length - 1)
                    {
                        Console.Clear();
                        Styles.MainLogo();
                        Console.SetCursorPosition(0, 15);
                        Styles.CenterTextYellow("Zostałeś wylogowany. Zapraszamy ponownie\n\n");
                        Thread.Sleep(1000);
                        return;
                    }
    //------------------------------------          1. Wyświetl moje pokoje          ------------------------------------ 
                    if (selectedIndex == 0)
                    {
                        Console.Clear();
                        MyRooms(Id, Login);

                        break;

                    }
    //---------------------------------------            2. Dodaj pokój            ---------------------------------------
                    else if (selectedIndex == 1)
                    {
                        Console.Clear();
                        AddRoom(Id, Login);
                        break;
                    }
    //--------------------------------------           3. Modyfikuj pokój          --------------------------------------
                    else if (selectedIndex == 2)
                    {
                        Console.Clear();
                        //modyfikuj pokój
                    }
                    //------------------------------------          4. Modyfikuj rezerwację          ------------------------------------
                    else if (selectedIndex == 3)
                    {
                        Console.Clear();
                        //Modyfikuj rezerwację
                    }
                    //------------------------------------          5. Usuń pokój          ------------------------------------
                    else if (selectedIndex == 4)
                    {
                        Console.Clear();
                        //usuń pokój
                    }
                    //------------------------------------          6. Moje rezerwacje          ------------------------------------
                    else if (selectedIndex == 5)
                    {
                        Console.Clear();
                        //Moje rezerwację
                    }
                    //------------------------------------          7. Modyfikuj rezerwację          ------------------------------------
                    else if (selectedIndex == 6)
                    {
                        Console.Clear();
                        //Modyfikuj rezerwacje
                    }
                    //------------------------------------          8. Usuń rezerwację          ------------------------------------
                    else if (selectedIndex == 7)
                    {
                        Console.Clear();
                        //Usuń rezerwacje
                    }
                    //------------------------------------          9. Wyloguj się          ------------------------------------

                    Console.ReadKey();
                    break;
            }
        }

    }

    //Pokolorowany AddRoom ;)
    public static void AddRoom(string userId, string login)
    {
        Room room = new Room();
        Styles.WidgetBar(userId, login);
        Console.SetCursorPosition(0, 8);

        room.Id = Login.GuidGenerator();
        room.OwnerId = userId;
        Styles.Cyan("Podaj nazwę: ");
        room.Name = Console.ReadLine();
        if (room.Name.Length > 14) { room.Name.Substring(0, 14); }

        Styles.Cyan("Czy pokój posiada tablice interaktywną? ");
        string ThereIsBoard = Console.ReadLine();
        if (ThereIsBoard.ToLower() == "y" || ThereIsBoard.ToLower() == "tak" || ThereIsBoard.ToLower() == "t" || ThereIsBoard.ToLower() == "yes")
        { room.InteractiveBoard = true; }
        else { room.InteractiveBoard = false; }

        Styles.Cyan("Maksymalna ilość osób na stanowisku to: ");
        room.Capacity = int.Parse(Console.ReadLine());

        Styles.Cyan("Podaj krótki opis pokoju (maksymalnie 23 znaki): ");
        room.Description = Console.ReadLine();
        if (room.Description.Length > 23) { room.Description.Substring(0, 23); }

        Styles.Cyan("Jaka cena za dzień wynajęcia stanowiska? [PLN]: ");
        room.Price = int.Parse(Console.ReadLine());

        RoomsService.MakeNewRoom(room);

        Styles.Yellow($"{room.Name} dodany/a");
        Thread.Sleep(1500);
        Console.Clear();

    }

    public static void MyRooms(string userId, string login)
    {
        Styles.WidgetBar(userId, login);
        Console.SetCursorPosition(0, 8);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" {0,-4} | {1,-20} | {2,-20} | {3,-14} | {4,-35} | {5,-5}", "Nr", "Nazwa", "Tablica interaktywna", "Max ilość osób", "Wyposażenie", "Cena [PLN]");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();

        string csvFile = Path.Combine("..\\..\\..\\AppData\\rooms.csv");

        string[] lines = File.ReadAllLines(csvFile);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] columns = lines[i].Split(",");

            if (columns.Length > 2 && columns[2].Contains(userId))
            {
                
                Console.WriteLine(" {0,-4} | {1,-20} | {2,-20} | {3,-14} | {4,-35} | {5,-5}", i, columns[1], columns[3], columns[4], columns[5], columns[6]);

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            }

        }
        

        Console.Read();
    }
}
