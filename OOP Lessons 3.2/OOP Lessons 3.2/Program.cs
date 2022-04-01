using System;

namespace OOP_Lessons_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World!";
            
            Console.WriteLine($"текст до метода: {text}");
            Console.WriteLine(Turnover(text));



            Console.ReadLine();
            
            string Turnover(string _text)
            {
                int a, b;
                char[] revers = new char[_text.Length];
                for ( a = _text.Length, b = 0; b < _text.Length; a--, b++)
                {
                    revers[b] = Convert.ToChar(_text[a - 1]);
                    
                }
                return new string(revers);
            }
        }
    }
}
