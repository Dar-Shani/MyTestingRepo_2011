using System;

namespace OOP_Lessons_2._2
{
    
    class Program
    {

        static void Main(string[] args)
        {
           
            Account cell = new Account();
            Account cell2 = new Account();
            Account cell3 = new Account();

            cell.EditBalance(10000);
            cell.typeAccount = (Account.type)3;
            Console.Write("1 ");
            cell.DemonstrateAccount();

            cell2.EditBalance(8000);
            cell2.typeAccount = (Account.type)2;
            Console.Write("2 ");
            cell2.DemonstrateAccount();

            cell3.EditBalance(15000);
            cell3.typeAccount = (Account.type)1;
            Console.Write("3 ");
            cell3.DemonstrateAccount();

            Console.ReadKey();
        }
    }
}