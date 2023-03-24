using System;

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
                        //Dodaj pokój
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

}
