using System;

namespace Lesson_3._2
{
    class Program
    {
        enum partner
        {
            Александра,
            Евгений,
            Валерия,
            Дмитрий,
            Александр
        }
        static void Main(string[] args)
        {
            String[,] directory = new string[5, 2];
            Random FormPartner = new Random();
            int Number = 0;

            for (int i = 0; i <= directory.GetLength(0) - 1; i++)
            {
                partner name = (partner)FormPartner.Next(5);
                directory[i, 0] = name.ToString();
                directory[i, 1] = Convert.ToString(FormPartner.Next(30000, 90000));
            }

            System.Console.WriteLine("    Имя         Номер телефона");

            for (int a = 0; a <= directory.GetLength(0) - 1; a++)
            {
                Number++;
                System.Console.WriteLine($"№ {Number} {directory[a, 0]}       \t {directory[a, 1]}");
            }
             
        }
    }
}
