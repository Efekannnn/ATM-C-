using System;
using System.ComponentModel;

namespace ATMApp.UI
{
    public static class Validator
    {
        public static T Convert<T>(string prompt)
        {
            bool isValid = false;
            string userInput;

            while (!isValid)
            {
                userInput = Utility.GetUserInput(prompt);

                try
                {
                    var converter = TypeDescriptor.GetConverter(typeof(T));
                    if (converter != null)
                    {
                        var result = (T)converter.ConvertFromString(userInput);
                        isValid = true;
                        return result;
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            return default;
        }
    }
}