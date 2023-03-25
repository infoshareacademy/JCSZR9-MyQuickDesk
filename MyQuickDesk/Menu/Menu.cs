using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


public class Menu
{
    //Menu główne
    public static void MainMenu()
    {
        string[] options = { "1. Logowanie ", "2. Rejestracja ", "3. Wyjście " };

        int selectedIndex = 0;

        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            Styles.MainLogo();
            Console.SetCursorPosition(0, 20);

            MoveMain(options, selectedIndex);

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
                        Styles.CenterTextYellow("Do zobaczenia\n\n\n\n\n\n");

                        Thread.Sleep(1000);
                        return;
                    }

                    if (selectedIndex == 0)
                    {
                        Console.Clear();
                        Login.LoginToSystem();
                        break;

                    }

                    else if (selectedIndex == 1)
                    {
                        Console.Clear();
                        Login.RegistrationMenu();
                        break;
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }

    public static void MoveMain(string[] options, int selectedIndex)
    {
        Console.Clear();
        Styles.MainLogo();
        Console.SetCursorPosition(0, 15);


        for (int i = 0; i < options.Length; i++)
        {

            if (i == selectedIndex)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
            }

            Console.WriteLine(options[i]);
            Console.ResetColor();
        }

    }

    public static void Move(string[] options, int selectedIndex, string ID, string login)
    {
        Console.Clear();
        Styles.WidgetBar(ID, login);
        Console.SetCursorPosition(0, 8);


        for (int i = 0; i < options.Length; i++)
        {

            if (i == selectedIndex)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
            }

            Console.WriteLine(options[i]);
            Console.ResetColor();
        }

    }



}
