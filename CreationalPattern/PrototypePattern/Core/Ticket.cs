using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern.Core
{
    [Serializable]
    public abstract class BaseClone<T> where T : class
    {
        public virtual T Clone()
        {
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, this);
            memoryStream.Position = 0;
            return (T) formatter.Deserialize(memoryStream);
        }
    }

    [Serializable]
    public class Ticket : BaseClone<Ticket>
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}