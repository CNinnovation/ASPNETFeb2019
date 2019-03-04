using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;

namespace DataContractSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // SerializationSample();
            JsonSerialization();
        }

        private static void JsonSerialization()
        {
            // Person p1 = new Person { FirstName = "Tom", LastName = "Turbo" };
            Person p1 = new Person("Tom", "Turbo");
            string json = JsonConvert.SerializeObject(p1);

            Person p2 = JsonConvert.DeserializeObject<Person>(json);
        }

        //private static void SerializationSample()
        //{
        //    Person p1 = new Person { FirstName = "Tom", LastName = "Turbo" };
        //    var serializer = new DataContractSerializer(typeof(Person));

        //    using (var writer = File.CreateText("sample"))
        //    {
        //        serializer.WriteObject(writer.BaseStream, p1);
        //    }
        //}
    }
}
