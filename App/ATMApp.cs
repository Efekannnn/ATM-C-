using System;

namespace ATMApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UI.AppScreen.Welcome();
            long cardNumber = UI.Validator.Convert<long>("Card Number");
            Console.WriteLine($"Your card number is {cardNumber}");
            UI.Utility.PressEnterToContinue();
        }
    }

}
