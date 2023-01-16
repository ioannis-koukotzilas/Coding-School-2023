using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    public class University : Institute {

        public string[]? Students { get; set; }
        public string[]? Courses { get; set; }
        public int[] Grades { get; set; }
        public DateTime[] ScheduleCourse { get; set; }
 

        public University() { }

        public University(string[] students) : this() {
            Students = students;
        }

        public University(string[] students, string[] courses) : this(students) {
            Courses = courses;
        }

        public University(string[] students, string[] courses, int[] grades) : this(students, courses) {
            Grades = grades;
        }

        public University(string[] students, string[] courses, int[] grades, DateTime[] scheduleCourse) : this(students, courses, grades) {
            ScheduleCourse = scheduleCourse;
        }

        public void GetStudents() { }

        public void GetCourses() { }

        public void GetGrades() { }

        public void SetSchedule() { }

    }

}
