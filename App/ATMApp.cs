using System;
using System.Collections.Generic;


namespace ATMApp
{
    class Program
    {
        private List<Domain.Entities.UserAccount>? userAccountList;
        private Domain.Entities.UserAccount? SelectedAccount;

        public void InitializeData()
        {
           userAccountList = new List<Domain.Entities.UserAccount>
           {
                new Domain.Entities.UserAccount
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
                new Domain.Entities.UserAccount
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
                new Domain.Entities.UserAccount
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
    }

}
