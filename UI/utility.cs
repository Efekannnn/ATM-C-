using System;
using System.Text;

namespace ATMApp.UI
{
    public class Utility
    {
        public static string GetSecretInput(string prompt)
        {
            bool isPrompt = true;
            string asterics = "";

            StringBuilder input = new StringBuilder();

            while (true)
            {
                if (isPrompt)
                {
                    Console.Write(prompt);
                }
                isPrompt = false;
                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    if (input.Length == 6)
                    {
                        break;
                    }
                    else
                    {
                        PrintMessage("Invalid pin length, pin must be 6 digits long", false);
                        isPrompt = true;
                        input.Clear();
                        asterics = "";
                        Console.Clear();
                        continue;
                    }
                }
                if (inputKey.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    asterics = asterics.Substring(0, asterics.Length - 1);
                    Console.Write("\b \b");
                }
                else if (inputKey.Key != ConsoleKey.Backspace)
                {
                    if (input.Length >= 6)
                    {
                        continue;
                    }
                    input.Append(inputKey.KeyChar);
                    asterics += "*";
                    Console.Write("*");
                }
            }
            return input.ToString();
        }
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