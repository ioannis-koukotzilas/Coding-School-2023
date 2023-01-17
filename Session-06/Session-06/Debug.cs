using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    public class Debug {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public Debug() {}

        public Debug(Guid id) {
            ID = id;
        }

        public Debug(string name) {
            Name = name;
        }

        public Debug(int age) {
            Age = age;
            Count++;
        }

        public Debug(Guid id, string name, int age) {
            ID = id;
            Name = name;
            Age = age;
        }

        // Helper constuctor
        public static Debug CreateFromLastName(string lastName) {
            Debug debug = new Debug();
            debug.LastName = lastName;
            return debug;
        }

        public int Count { get; set; } = 0;


        public void GetName() { }

        public void SetName(string Name) { }

        public void GetMessage() {
            Console.WriteLine($"Person name is {Name} and is {Age} years old. ID is {ID}.");
        }

    }

}
