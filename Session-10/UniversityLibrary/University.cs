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
        public string? UName { get; set; }

        public University() {
            Students = new List<Student>();
            Courses = new List<Course>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<ScheduledCourse>();
        }

    }

    public class Student {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public int RegistrationNumber { get; set; }

        public Student() {
            ID = Guid.NewGuid();
        }

    }

    public class Grade {

        public Guid ID { get; set; }
        public int GradeNumber { get; set; }

        public Grade() {
            ID = Guid.NewGuid();
        }

    }

    public class Course {

        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public Course() {
            ID = Guid.NewGuid();
        }

    }

    public class ScheduledCourse {

        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public ScheduledCourse() {
            ID = Guid.NewGuid();
        }

    }

}
