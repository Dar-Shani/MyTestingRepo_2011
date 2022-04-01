using System;
using System.IO; 

namespace OOP_Lessons_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fileAdres = "C:\\Users\\Sarol\\source\\repos\\OOP Lessons 3.3\\OOP Lessons 3.3\\bin\\Debug\\netcoreapp3.1\\Контакты.txt";
            string filetext = File.ReadAllText(fileAdres);

            Console.WriteLine(filetext);

            SearchMail(ref filetext);

            Console.WriteLine("\n\nИтого \n" + filetext);
            File.WriteAllText("Mail.txt", filetext);
            Console.WriteLine("\nФайл сохранён");
            Console.ReadLine();
        }
        public static void SearchMail(ref string s)
        {
            char[] divider = new char[s.Length];
            int count = 0;
            for (int a = 0; a < s.Length; a++)
            {
                if(s[a] == '%')
                {
                    for(int b = a + 2; b < s.Length; b++)
                    {
                        if ((s[b] != ' ') & (s[b] != '\n'))
                        {
                            divider[count] = s[b];
                            count++;
                        } else
                        {
                            divider[count] = '\n';
                            count++;
                            a = b + 1;
                            break;
                        } 
                    }
                }
            }
            s = new string(divider);
        }
    }
}
