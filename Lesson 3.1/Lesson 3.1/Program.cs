using System;

namespace Lesson_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Array =  {{1,3,5,7,9},
                             {2,4,6,8,10}};
            
            int Size = 0;

            while (Size < 110) {
                for (int a = 0; a <= Array.GetLength(1) - 1; a++)
                {
                    for (int b = 0; b <= Size; b++)
                        System.Console.Write(" ");

                    System.Console.Write($"{Array[0, a]} - {Array[1, a]}");
                    System.Console.WriteLine();

                    Size++;
                }
                System.Console.WriteLine();
            }
        }
    }
}
