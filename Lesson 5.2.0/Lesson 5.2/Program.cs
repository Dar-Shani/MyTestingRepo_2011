using System;
using System.IO;

namespace Lesson_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Дата и время {DateTime.Now}, время входа записанно в файл startup.txt");
            File.WriteAllText("startup.txt", "Дата входа " + DateTime.Now);
        }
    }
}
