using System;

namespace ATMApp.UI
{
    public class Utility
    {
        public static void PrintMessage(string message, bool success = true)
        {
            if (success)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            PressEnterToContinue();
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}: ");
            return Console.ReadLine();
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}