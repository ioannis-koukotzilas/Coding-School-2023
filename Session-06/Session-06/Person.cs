using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_06 {
    public class Person {

        // Properties

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        // Constructors

        public Person() { }

        public Person(Guid id) : this() {
            ID = id;
        }

        public Person(Guid id, string name) : this(id) {
            Name = name;
        }

        public Person(Guid id, string name, int age ) : this(id, name) {
           Age = age;
        }

        // Methods

        public void GetName() {}

        public void SetName(string Name) {}

        public void GetMessage(string Name, int Age) {
            Console.WriteLine($"Person name is {Name} and is {Age} years old.");
        }

    }

}
