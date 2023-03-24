using System;

public class Styles
{
    public static void Cyan(string text)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(text);
        Console.ResetColor();
    }

    public static void Red(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void DarkCyan(string text)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void Yellow(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void CenterTextCyan(string centeredText)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        int windowWidth = Console.WindowWidth;
        string indent = new string(' ', (windowWidth - centeredText.Length) / 3);
        Console.WriteLine(indent + centeredText);
        Console.ResetColor();
    }

    public static void CenterTextYellow(string centeredText)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        int windowWidth = Console.WindowWidth;
        string indent = new string(' ', (windowWidth - centeredText.Length) / 3);
        Console.WriteLine(indent + centeredText);
        Console.ResetColor();
    }

    public static void WidgetBar(string Id, string Login)
    {

        DateTime now = DateTime.Now;

        Console.SetCursorPosition(5, 1);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("MyQuickDesk");
        Console.ResetColor();

        Console.SetCursorPosition(50, 1);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(now.ToString("HH:mm"));
        Console.WriteLine(" " + now.ToShortDateString());

        Console.SetCursorPosition(5, 3);
        Console.Write($"Witaj, {Login}!");
        Console.ResetColor();

        Console.SetCursorPosition(0, 4);
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($@"::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");
        Console.ResetColor();
    }

    public static void MainLogo()
    {
        string logo = $@"
    
          __  __        ____        _      _    _____            _    
         |  \/  |      / __ \      (_)    | |  |  __ \          | |   
         | \  / |_   _| |  | |_   _ _  ___| | _| |  | | ___  ___| | __
         | |\/| | | | | |  | | | | | |/ __| |/ / |  | |/ _ \/ __| |/ /
         | |  | | |_| | |__| | |_| | | (__|   <| |__| |  __/\__ \   < 
         |_|  |_|\__, |\___\_\\__,_|_|\___|_|\_\_____/ \___||___/_|\_\
                  __/ |                                               
                 |___/                                                
                                                                                             ";
        Cyan(logo);
    }
}
