using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lesson_2
{
    class Account
    {
        private int accountID;
        private int balance;

        public enum type
        {
            current = 1,
            credit = 2,
            deposit = 3,
            budget = 4
        }

        public type typeAccount = new type();
        
        public int EditAccount(int _accountID)
        {
            this.accountID = _accountID;
            return accountID;
        }

        public int EditBalance(int _balance)
        {
            this.balance = _balance;
            return accountID;
        }

        public void DemonstrateAccount()
        {
            Console.WriteLine($"Номер счёта {accountID} Баланс {balance} Тип счёта {typeAccount}");
        }
    }
}
