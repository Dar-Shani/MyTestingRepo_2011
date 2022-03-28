using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lessons_2._5
{

    class Account
    {
        public static int[] arrayID = new int[3];
        public static int accountID;
        private int balance;

        public enum type
        {
            current = 1,
            credit = 2,
            deposit = 3,
            budget = 4
        }


        public type typeAccount = new type();
        public int id = RegistrID();


        public int EditBalance(int _balance)
        {
            this.balance = _balance;
            return balance;
        }

        public void DemonstrateAccount()
        {
            Console.WriteLine($"Номер счёта №{id} Баланс {balance} Тип счёта {typeAccount}");
        }

        static int RegistrID()
        {
            Random randomID = new Random();
            accountID = randomID.Next(1, 1000);

            for (int a = 0; a < arrayID.Length; a++)
            {
                if (arrayID[a] == accountID)
                {
                    RegistrID(); //при обнаружении дубликата перезапускаем метод 
                }
                if (arrayID[a] == 0)
                {
                    arrayID[a] = accountID;
                    break;
                }
                if (arrayID[^1] != 0)
                {
                    Console.WriteLine("Ошибка - массив переполнен");
                    break;
                }
            }
            return accountID;
        }

        public void TakeMoney(int _get)
        {
            if(_get <= balance)
            {
                Console.WriteLine($"Деньги сняты {_get}");
                balance = balance - _get;
                DemonstrateAccount();
            } else
            {
                Console.WriteLine("Не достаточно средств");
                DemonstrateAccount();
            }
        }
        public void GetMoney(int _take)
        {
            Console.WriteLine($"Деньги перечисленны на счёт {_take}");
            balance = balance + _take;
            DemonstrateAccount();
        }
    }
}
