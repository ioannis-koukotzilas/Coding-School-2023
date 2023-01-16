using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06 {

    public class Course {

        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }

        public Course() { }

        public Course(Guid id) : this() {
            ID = id;
        }

        public Course(Guid id, string code) : this(id) {
            Code = code;
        }

        public Course(Guid id, string code, string subject) : this(id, code) {
            Subject = subject;
        }

        public void GetMessage(string Code, string Subject) {
            Console.WriteLine($"Code is {Code}. Subject is '{Subject}'.");
        }

    }

}
