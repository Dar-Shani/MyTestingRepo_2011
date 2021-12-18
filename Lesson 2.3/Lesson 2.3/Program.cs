using System;

namespace Lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число");

            int number = System.Convert.ToInt32(System.Console.ReadLine());

            if (number % 2 == 0)
                System.Console.WriteLine($"Число является чётным ({number})");
            else
                System.Console.WriteLine($"Число не является чётным ({number})");


        }
    }
}
