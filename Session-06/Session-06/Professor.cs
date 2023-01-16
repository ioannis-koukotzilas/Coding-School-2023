using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {
    public class Professor : Person {

        public string? Rank { get; set; }
        public string[]? Courses { get; set; }

        public Professor() { }

        public Professor(string rank) : this() {
            Rank = rank;
        }

        public Professor(string rank, string[] courses) : this(rank) {
            Courses = courses;
        }

        public void Teach(string course, DateTime dateTime) { }

        public void SetGrade(int studentID, int courseID, int grade) { }

        public void GetName() {}

        public void GetMessage(string Name, int Age, string Rank) {
            Console.WriteLine($"Professor name is {Name} and is {Age} years old. Rank is {Rank}.");
        }

    }

}
