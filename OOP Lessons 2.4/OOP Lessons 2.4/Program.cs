using System;

namespace OOP_Lessons_2._4
{

    class Program
    {

        static void Main(string[] args)
        {

            Account cell = new Account
            {
                ID = 1,
                Balance = 5000,
                //Number = (Account.type) 1
            };
            Console.WriteLine($"Номер счёта {cell.ID} баланс {cell.Balance} тип cell.Number");

            Account cell1 = new Account
            {
                ID = 2,
                Balance = 7500,
                //Number = (Account.type)2
            };
            Console.WriteLine($"Номер счёта {cell1.ID} баланс {cell1.Balance} тип cell1.Number");

            Account cell3 = new Account
            {
                ID = 3,
                Balance = 10000,
                //Number = (Account.type)1
            };
            Console.WriteLine($"Номер счёта {cell3.ID} баланс {cell3.Balance} тип cell3.Number");

            Console.ReadKey();
        }
    }
}
