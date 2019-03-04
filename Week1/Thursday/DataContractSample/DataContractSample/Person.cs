using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractSample
{
    // [DataContract]

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

       // [DataMember]
        public string FirstName { get; set; }

     //   [DataMember]
        private string _lastName;

        [JsonIgnore]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

    }
}
