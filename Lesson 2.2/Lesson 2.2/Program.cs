using System;

namespace Lesson_1._2
{
    class Program
    {
        enum Season
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {

            System.Console.WriteLine("Укажите порядковый номер месяца");
            int Ntylze = System.Convert.ToInt32(System.Console.ReadLine());

            Season tulze = (Season)Ntylze;

            System.Console.WriteLine(tulze);
        }
    }
}