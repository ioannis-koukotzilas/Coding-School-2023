using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLibrary {

    public class University {

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<ScheduledCourse> ScheduledCourses { get; set; }
        public string? UniversityName { get; set; }

        public University() {
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<ScheduledCourse>();
        }

    }

    public class Person {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

        public Person() {
            ID = Guid.NewGuid();
        }

    }

    public class Student : Person {

        public int RegistrationNumber { get; set; }
        public List<Course> Courses { get; set; }


        public Student(string name, int age, int registrationNumber, List<Course> courses) {
            Name = name;
            Age = age;
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }

    }

    public class Course {

        public Guid CourseID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public Course() {
            CourseID = Guid.NewGuid();
        }

    }

    public class Grade {

        public int GradeNumber { get; set; }


    }

    public class ScheduledCourse : Course {

        public string? ExpectedDate { get; set; }

    }

}
