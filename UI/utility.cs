using System;

namespace ATMApp.UI
{
    public class Utility
    {
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