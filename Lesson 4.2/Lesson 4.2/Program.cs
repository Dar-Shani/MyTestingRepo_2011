using System;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите набор чисел разделённый пробелом");
            string number = System.Console.ReadLine();
            char[] count = new char[number.Length];
            string sum = null;
            int lvl = 0;
            int sumTotal = 0;

            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] != ' ')
                {
                    
                    count[lvl] = number[i];
                    sum = new string(count);
                    lvl++;

                } else
                {
                    sumTotal += System.Convert.ToInt32(sum.ToString());
                    sum = null;

                    for (int b = 0; b < count.Length; b++)
                        count[b] = default;
                    lvl = 0;
                }
            }
            sumTotal += System.Convert.ToInt32(sum.ToString());
            System.Console.WriteLine($"Общая сумма {sumTotal}");
        }
    }
}
