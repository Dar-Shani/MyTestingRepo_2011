using System;

namespace OOP_Lessons_2._5
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

            Console.WriteLine("\n\nВыберите операцию, например " +
                        "\nснять: [-] [номер счёта] [сумма]" +
                        "\nвнести: [+] [номер счёта] [сумма]" +
                        "\nвводите без скобок с пробелами.");
            
            string[] command = Console.ReadLine().Split();
            //Console.WriteLine(command[0] + command[1] + command[2]);

            if (command[0] == "+")
            {
                switch (Convert.ToInt32(command[1]))
                {
                    case 1:
                        cell.GetMoney(Convert.ToInt32(command[2]));
                        break;

                    case 2:
                        cell2.GetMoney(Convert.ToInt32(command[2]));
                        break;

                    case 3:
                        cell.GetMoney(Convert.ToInt32(command[2]));
                        break;
                }
            }
            if (command[0] == "-")
            {
                switch (Convert.ToInt32(command[1]))
                {
                    case 1:
                        cell.TakeMoney(Convert.ToInt32(command[2]));
                        break;

                    case 2:
                        Console.WriteLine("Выберите сумму");
                        cell2.TakeMoney(Convert.ToInt32(command[2]));
                        break;

                    case 3:
                        Console.WriteLine("Выберите сумму");
                        cell3.TakeMoney(Convert.ToInt32(command[2]));
                        break;
                }
            }


            Console.ReadKey();
        }
    }
}
