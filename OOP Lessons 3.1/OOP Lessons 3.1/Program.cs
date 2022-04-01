using System;

namespace OOP_Lessons_3._1
{
    class Program
    {

        static void Main(string[] args)
        {

            Account cell = new Account(76,800,1);
            Account cell2 = new Account(118,1000);
            
            cell2.Balance = cell2.Balance + GetMoney(cell, 500);

            cell.Demonstration("После операции");
            cell2.Demonstration("После операции");
            
           
            


            Console.ReadKey();
             
            int GetMoney(Account _cell, int _money)
            {
                _cell.Balance = _cell.Balance - _money;
                return _money;
            }

        }
        
    }
}
