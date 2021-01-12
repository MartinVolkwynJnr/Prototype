using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    //PROTOTYPE  && Concrete Prototype
    [Serializable]
    class Color : ICloneable
    {
        // Gets or sets red value
        public byte Red { get; set; }

        // Gets or sets green value
        public byte Green { get; set; }

        // Gets or sets blue channel
        public byte Blue { get; set; }

        // Returns shallow or deep copy
        public object Clone(bool shallow)
        {
            return shallow ? Clone() : DeepCopy();
        }

        // Creates a shallow copy
        public object Clone()
        {
            Console.WriteLine(
                "Shallow copy of color RGB: {0,3},{1,3},{2,3}",
                Red, Green, Blue);

            return this.MemberwiseClone();
        }

        // Creates a deep copy
        public object DeepCopy()
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();

            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);

            object copy = formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine(
                "*Deep*  copy of color RGB: {0,3},{1,3},{2,3}",
                (copy as Color).Red,
                (copy as Color).Green,
                (copy as Color).Blue);

            return copy;
        }
    }
}