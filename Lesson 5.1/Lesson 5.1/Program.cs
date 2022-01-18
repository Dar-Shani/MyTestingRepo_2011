using System;
using System.IO;

namespace Lesson_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите текст");
            string text = System.Console.ReadLine();
            File.WriteAllText("Readme.txt", text);

        }
    }
}
