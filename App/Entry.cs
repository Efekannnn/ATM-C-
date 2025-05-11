using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.App
{
    class Entry
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