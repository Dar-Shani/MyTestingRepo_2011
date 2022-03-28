using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lessons_2._3
{

    class Account
    {
        private enum type
        {
            current = 1,
            credit = 2,
            deposit = 3,
            budget = 4
        }

        public static int[] arrayID = new int[4];
        public static int accountID;

        private int id;
        private int balance;
        type Number = new type();

        public Account()
        {
            
            this.balance = Registr(1, 100, false, 1, false);
            this.Number = (type) Registr(1, 4, false, 1, false);
            this.id = Registr(1, 1000, false, 1, true);
            /*Тут номер счёта находится ниже что бы исключить его перебивания
             * балансом и типом счёта*/
            
            Console.WriteLine($"Номер счёта {accountID} баланс {balance} тип {Number}");
        }

        public Account(int _id)
        {
            this.id = _id;
            this.balance = Registr(1, 100, false, 1, false);
            this.Number = (type) Registr(1, 4, false, 1, false);

            Registr(1, 100, true, _id, true);

            Console.WriteLine($"Номер счёта {accountID} баланс {balance} тип {Number}");
        }

        public Account(int _id, int _balance)
        {
            this.id = _id;
            this.balance = _balance;
            this.Number = (type) Registr(1, 4, false, 1, false);

            Registr(1, 100, true, _id, true);

            Console.WriteLine($"Номер счёта {accountID} баланс {balance} тип {Number}");
        }

        public Account(int _id, int _balance, int _type)
        {
            this.id = _id;
            this.balance = _balance;
            this.Number = (type) _type;

            Registr(1, 100, true, _id, true);

            Console.WriteLine($"Номер счёта {accountID} баланс {balance} тип {Number}");
        }

        static int Registr(int _min, int _max, bool _edit, int _id, bool _editArray)
        {
            if (!_edit)
            {
                Random randomID = new Random();
                accountID = randomID.Next(_min, _max);
            }

            if (_edit)
                accountID = _id;
                
            
            
            if (_editArray)
            {
                for (int a = 0; a < arrayID.Length; a++)
                {
                    if (arrayID[a] == accountID)
                    {
                        Registr(_min, _max, _edit, _id, _editArray); //при обнаружении дубликата перезапускаем метод 
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
            }
            return accountID;
        }
    }
}
