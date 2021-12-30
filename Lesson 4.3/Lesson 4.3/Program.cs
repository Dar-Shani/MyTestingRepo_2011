using System;

namespace Lesson_4._3
{
    class Program
    {
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }

        static String Seasonality (int _number)
        {
            if ((_number < 13 && _number > 10) || _number < 2)
            {
                return Convert.ToString(Season.Winter);
            }
            if (_number >= 2 && _number < 5)
            {
                return Convert.ToString(Season.Spring);
            }
            if (_number >= 5 && _number < 8)
            {
                return Convert.ToString(Season.Summer);
            }
            if (_number >= 8 && _number < 11)
            {
                return Convert.ToString(Season.Autumn);
            } else
            {
                return "Ошибка: Введите число от 1 до 12";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите месяц");
            int number = Convert.ToInt32(Console.ReadLine());
            
            
            System.Console.WriteLine(Seasonality(number));  
        }
    }
}
