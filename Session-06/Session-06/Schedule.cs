using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    public class Schedule {

        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Calendar { get; set; }

        public Schedule() { }

        public Schedule(Guid id) : this() {
            ID = id;
        }

        public Schedule(Guid id, Guid courseId) : this(id) {
            CourseID = courseId;
        }

        public Schedule(Guid id, Guid courseId, Guid professorId) : this(id, courseId) {
            ProfessorID = professorId;
        }

        public Schedule(Guid id, Guid courseId, Guid professorId, DateTime calendar) : this(id, courseId, professorId) {
            Calendar = calendar;
        }

    }

}
