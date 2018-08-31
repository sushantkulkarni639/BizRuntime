using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    [Serializable]
    class SerializEg
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            SerializEg obj = new SerializEg();
            obj.ID = 1;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"E:\Serialize.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"E:\Serialize.txt", FileMode.Open, FileAccess.Read);
            SerializEg objnew = (SerializEg)formatter.Deserialize(stream);

            Console.WriteLine(objnew.ID);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();
        }
    }
}
