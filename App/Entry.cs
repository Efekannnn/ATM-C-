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
            ATMApp atmApp = new ATMApp();
            atmApp.CheckCardNumberAndPin();
            UI.Utility.PressEnterToContinue();
        }
    }
}