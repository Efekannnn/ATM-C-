using System;
using System.Collections.Generic;
using ATMApp.Domain.Entities;
using ATMApp.Domain.Interfaces;
using ATMApp.UI;


namespace ATMApp
{
    public class ATMApp : IUserLogin
    {
        private List<UserAccount>? userAccountList;
        private UserAccount? SelectedAccount;

        public void InitializeData()
        {
           userAccountList = new List<UserAccount>
           {
                new UserAccount
                {
                    Id = 1,
                    CardNumber = 123456789001,
                    CardPin = 1234,
                    AccountNumber = 123456789001,
                    FullName = "John Doe",
                    AccountBalance = 1000,
                    TotalLoginAttempts = 0,
                    IsLocked = false
                },
                new UserAccount
                {
                    Id = 2,
                    CardNumber = 123456789002,
                    CardPin = 1234,
                    AccountNumber = 123456789002,
                    FullName = "Jane Doe",
                    AccountBalance = 2000,
                    TotalLoginAttempts = 0,
                    IsLocked = false
                },
                new UserAccount
                {
                    Id = 3,
                    CardNumber = 123456789003,
                    CardPin = 1234,
                    AccountNumber = 123456789003,
                    FullName = "John Doe",
                    AccountBalance = 1000,
                    TotalLoginAttempts = 0,
                    IsLocked = false
                }
           };
        }

        public void CheckCardNumberAndPin()
        {
            bool isCorrectLogin = false;
            UserAccount tempUserAccount = new UserAccount();
            
            long cardNumber = Validator.Convert<long>("Enter your card number: ");
            int cardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your pin: "));
            
            tempUserAccount.CardNumber = cardNumber;
            tempUserAccount.CardPin = cardPin;
        }
    }

}
