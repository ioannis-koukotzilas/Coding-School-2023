using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    public class Student : Person {

        public int RegistrationNumber { get; set; }
        public string[]? Courses { get; set; }

        public Student() { }

        public Student(int regNum) : this() {
            RegistrationNumber = regNum;
        }

        public Student(int regNum, string[] courses) : this(regNum) {
            Courses = courses;
        }

        public void Attend(string course, DateTime dateTime) { }

        public void WriteExam(string course, DateTime dateTime) { }

        public void GetMessage(string Name, int Age, int RegistrationNumber) {
            Console.WriteLine($"Student name is {Name} and is {Age} years old. Registration number is {RegistrationNumber}.");
        }

    }

}
