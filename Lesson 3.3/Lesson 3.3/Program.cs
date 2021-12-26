using System;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string text = System.Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
                System.Console.Write(text[i]);
        }
    }
}
