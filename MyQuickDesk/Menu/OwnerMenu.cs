using System;
using Logika_Beznesowa;
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

                    if (selectedIndex == 0)
                    {
                        Console.Clear();
                        //Wyświetl moje pokoje
                        break;

                    }

                    else if (selectedIndex == 1)
                    {
                        Console.Clear();
                        AddRoom(Id);
                        break;
                    }
                    else if (selectedIndex == 2)
                    {
                        Console.Clear();
                        //modyfikuj pokój
                    }

                    else if (selectedIndex == 3)
                    {
                        Console.Clear();
                        //Modyfikuj rezerwację
                    }
                    else if (selectedIndex == 4)
                    {
                        Console.Clear();
                        //usuń pokój
                    }
                    else if (selectedIndex == 5)
                    {
                        Console.Clear();
                        //Moje rezerwację
                    }
                    else if (selectedIndex == 6)
                    {
                        Console.Clear();
                        //Modyfikuj rezerwacje
                    }
                    else if (selectedIndex == 7)
                    {
                        Console.Clear();
                        //Usuń rezerwacje
                    }

                    Console.ReadKey();
                    break;
            }
        }

    }

    public static void AddRoom(string userId)
    {
        Room room = new Room();

        room.Id = Login.GuidGenerator();
        room.OwnerId = userId;
        Console.WriteLine("Podaj nazwę pokoju:");
        room.Name = Console.ReadLine();
        if (room.Name.Length > 14) { room.Name.Substring(0, 14); }

        Console.WriteLine("Czy pokój posiada tablice interaktywną?");
        string ThereIsBoard = Console.ReadLine();
        if (ThereIsBoard.ToLower() == "y" || ThereIsBoard.ToLower() == "tak" || ThereIsBoard.ToLower() == "t" || ThereIsBoard.ToLower() == "yes")
        { room.InteractiveBoard = true; }
        else { room.InteractiveBoard = false; }

        Console.WriteLine("Maksymalna ilość osób na stanowisku to:");
        room.Capacity = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj krótki opis pokoju (maksymalnie 23 znaki)");
        room.Description = Console.ReadLine();
        if (room.Description.Length > 23) { room.Description.Substring(0, 23); }

        Console.WriteLine("Jaka cena za dzień wynajęcia stanowiska? [PLN]");
        room.Price = int.Parse(Console.ReadLine());

        RoomsService.MakeNewRoom(room);
        Console.Clear();

    }

}
