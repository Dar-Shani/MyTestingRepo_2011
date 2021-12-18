using System;

namespace Lesson_2._5
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
            //System.Console.WriteLine("Минимальная температура ?");
            //int minTemperature = Convert.ToInt32(System.Console.ReadLine());

            //System.Console.WriteLine("Максимальная температура ?");
            //int maxTemperature = Convert.ToInt32(System.Console.ReadLine());

            //int STemp = (minTemperature + maxTemperature) / 2;
            int STemp = 0;

            System.Console.Clear();

            System.Console.WriteLine($"Средняя температура: {STemp}");

            System.Console.WriteLine("Укажите порядковый номер месяца");

            int Ntylze = System.Convert.ToInt32(System.Console.ReadLine());

            Season tylze = (Season)Ntylze;

            if ((Ntylze == 1 || Ntylze >= 10) && STemp == 0)
                System.Console.WriteLine($"Дождливая Зима");
            else System.Console.WriteLine(tylze);

            
        }
    }
}
