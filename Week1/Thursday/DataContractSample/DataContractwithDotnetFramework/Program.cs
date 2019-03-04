using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SerializationSample();

            string s1 = "one";  // 1
            string s2 = "two";  // 2
            string s3 = "three"; //3
            string s4 = s1 + s2 + s3;  // s1 + s2 4; + s3 5

            var sb = new StringBuilder(260);
            sb.ToString()

            string s5 = $"{s1} {s2}";
            var coll = new List<int>(1200);
            for (int i = 0; i < 1000; i++)
            {
                coll.Add(i);
            }

        }

        private static void SerializationSample()
        {
            Person p1 = new Person { FirstName = "Tom", LastName = "Turbo" };
            var serializer = new DataContractSerializer(typeof(Person));

            using (var writer = File.CreateText("sample"))
            {
                serializer.WriteObject(writer.BaseStream, p1);
            }

            var serializer2 = new NetDataContractSerializer();
            using (var writer = File.CreateText("sample2"))
            {
                serializer2.WriteObject(writer.BaseStream, p1);
            }

        }
    }
}
