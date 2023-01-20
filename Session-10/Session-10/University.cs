using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_10 {
    internal class University {

        
    }

    internal class Person {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person() {}

        public Person(Guid id) {
            ID = Guid.NewGuid();
        }

        public Person( string name) {
            Name = name;
        }

        public Person(int age) {
            Age = age;
        }

    }

    internal class Student : Person {

        public Student() { }

        public Student(string name) : base(name)  { }
        public Student(Guid id) : base(id) { }
        public Student(int age) : base(age) { }

    }


}
