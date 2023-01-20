using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_10 {
 

    internal class University {

        public Student[]? Students { get; set; }
        public Course[]? Courses { get; set; }
        public Grade[]? Grades { get; set; }
        public ScheduledCourse[]? ScheduledCourses { get; set; }

    }

    internal class Student : University {

        public Guid ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int Age { get; set; }
        public int RegistrationNumber { get; set; }

        public Student() {
            ID = Guid.NewGuid();
        }

    }

    internal class Course : University {

        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public Course() {
            ID = Guid.NewGuid();
        }

    }

    internal class Grade : University {

        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeNumber { get; set; }

    }

    internal class ScheduledCourse : University {

        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public ScheduledCourse() {
            ID = Guid.NewGuid();
        }

    }

}
