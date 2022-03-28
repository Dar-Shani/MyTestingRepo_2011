using System;

namespace OOP_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Account cell = new Account();

           
            cell.EditAccount(21);
            cell.EditBalance(10000);
            cell.typeAccount = (Account.type) 3;
            cell.DemonstrateAccount();

            Console.ReadLine();
        }
    }
}
