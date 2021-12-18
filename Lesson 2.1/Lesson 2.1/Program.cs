using System;

namespace Lesson_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Минимальная температура ?");
            int minTemperature = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Максимальная температура ?");
            int maxTemperature = Convert.ToInt32(System.Console.ReadLine());

            int STemp = (minTemperature + maxTemperature) / 2;

            System.Console.WriteLine($"Средняя температура: {STemp}");
        }
    }
}
