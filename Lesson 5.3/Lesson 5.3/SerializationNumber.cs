using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson_5._3
{
    [Serializable]
    class SerializationNumber
    {
        public byte number { get; set; }

        public SerializationNumber(byte _number)
        {
            number = _number;
        }
    }
}
