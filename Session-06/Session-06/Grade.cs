using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    public class Grade {

        public Guid ID { get; set; }
        public Guid StudentID { get; set; }
        public Guid CourseID { get; set; }
        public int GradeNumber { get; set; }

        public Grade() { }

        public Grade(Guid id) : this() {
            ID = id;
        }

        public Grade(Guid id, Guid studentId) : this(id) {
            StudentID = studentId;
        }

        public Grade(Guid id, Guid studentId, Guid courseId) : this(id, studentId) {
            CourseID = courseId;
        }

        public Grade(Guid id, Guid studentId, Guid courseId, int grade) : this(id, studentId, courseId) {
            GradeNumber = grade;
        }

        public void GetMessage(int Grade) {
            Console.WriteLine($"Grade is {Grade}.");
        }

    }

}
