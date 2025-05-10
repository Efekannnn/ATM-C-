
using System;

namespace ATMApp.UI
{
    public class AppScreen
    {
        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "ATM App";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nWelcome to the ATM App");
            Console.WriteLine("Please enter your card number: ");
            Utility.PressEnterToContinue();
        }
    }
}