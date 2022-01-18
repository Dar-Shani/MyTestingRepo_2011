using System;

namespace Lesson_4._1
{

    
    class Program
    {
        static string GetFullName(string _firstName, string _lastName, string _patronymic)
        {
            return _firstName +" "+ _lastName +" "+ _patronymic;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Поэтапно укажите ФИО сотрудников.\nУкажите число сотрудников");

            int count = Convert.ToInt32(System.Console.ReadLine());
            string[] list = new string[count];
            int number = 1;
            int number2 = count;

            System.Console.Clear();
            count = 0;
            System.Console.WriteLine("Введите ФИО сотрудников.");

            while(count < list.Length)
            {
                System.Console.WriteLine($"Укажите Фамилию сотрудника № {number}"); 
                string firstName = System.Console.ReadLine();
               
                System.Console.WriteLine($"Укажите Имя сотрудника № {number}");
                string lastName = System.Console.ReadLine();
                
                System.Console.WriteLine($"Укажите Отчество сотрудника № {number}");
                string patronymic = System.Console.ReadLine();

                
                System.Console.Clear();
                System.Console.WriteLine($"Заполнен {number} из {number2}");

                list[count] = GetFullName(firstName,lastName,patronymic);
                number++;
                count++;
            }
            number = 1;
            for(int i = 0; i < list.Length; i++)
            {
                System.Console.WriteLine($"{number}) {list[i]}");
                number++;
            }
        }
    }
}
