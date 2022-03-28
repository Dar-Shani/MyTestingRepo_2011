using System;

namespace OOP_Lessons_2._3
{

    class Program
    {

        static void Main(string[] args)
        {

            Account cell = new Account();
            Account cell2 = new Account(118);
            Account cell3 = new Account(987,8000);
            Account cell4 = new Account(999, 8500, 1);
            
            Console.ReadKey();
        }
    }
}
