using SHINS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHINS
{
        class Person
        {
            public List<Person>  PersonList { get; set; }
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Type { get; set; }

        public Person() { }  // default constructor 

        public Person(string id, string firstName, string lastName, string type)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Type = type;
        }

        public static implicit operator Person(List<Person> v)
        {
            throw new NotImplementedException();
        }
    }

    
}
