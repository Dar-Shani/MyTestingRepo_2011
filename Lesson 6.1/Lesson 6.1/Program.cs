using System;
using System.Diagnostics;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список запущенный процессов.");
           

            foreach (Process proc in Process.GetProcesses())
                System.Console.WriteLine($"\nИмя процесса {proc.ProcessName} \nID {proc.Id}");
                
            
            System.Console.WriteLine("Укажите ID процесса для завершения.");
            int num = System.Convert.ToInt32(Console.ReadLine());

            Process processKill = Process.GetProcessById(num);
            System.Console.WriteLine($"Выбран процесс {processKill.ProcessName} время запуска {processKill.StartTime}");
           
            foreach (Process proc in Process.GetProcesses())
            {
                if (proc.ProcessName == processKill.ProcessName)
                    proc.Kill();
            }
            System.Console.WriteLine($"Процессы ненайдены {processKill.ProcessName}");
        }
    }
}
