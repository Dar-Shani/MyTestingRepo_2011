using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Lesson_5._3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите число от 0 до 255");
            byte consolNymber  = System.Convert.ToByte(System.Console.ReadLine());


            //SerializationNumber binF = new SerializationNumber(consolNymber);
            
            BinaryFormatter binary = new BinaryFormatter();

            binary.Serialize(new FileStream("BinaruText", FileMode.OpenOrCreate), new SerializationNumber(consolNymber));
            System.Console.WriteLine("Выполненно");

            /*using(FileStream fBin = new FileStream("BinaruText.txt", FileMode.OpenOrCreate))
            {
                binary.Serialize(fBin, binF);
            }*/

           
        }
    }
}
