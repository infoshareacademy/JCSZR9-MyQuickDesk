using Menu_Diana_Kosel;
using System.ComponentModel;
using Logika_Beznesowa;

namespace MyQuickDesk_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room();

            Menu.PrintMenu(room1);


            //Console.ReadLine();
        }
    }
}