using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_10 {
 

    internal class University {

        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public List<Grade> Grades { get; set; }

        public List<ScheduledCourse> ScheduledCourses { get; set; }

        public string? Name { get; set; }

        public University() {
            Students = new List<Student>();
        }

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

    internal class Grade {

        public Guid ID { get; set; }
        public int GradeNumber { get; set; }

        public Grade() { 
            ID = Guid.NewGuid();
        }

    }

    internal class Course {

        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public Course() {
            ID = Guid.NewGuid();
        }

    }

    internal class ScheduledCourse {

        public Guid ID { get; set; }
        public string? Code { get; set; }
        public string? Subject { get; set; }

        public ScheduledCourse() {
            ID = Guid.NewGuid();
        }

    }



    public class Serializer {

   


        public void SerializeToFile(object obj, string fileName) {

           
            string jsonString = JsonSerializer.Serialize(obj);

            File.WriteAllText(fileName, jsonString);
        }


        public T DeserializeFromFile<T>(string fileName) {

            string jsonString = File.ReadAllText(fileName);

            T? obj = JsonSerializer.Deserialize<T>(jsonString);

            return obj;
        }


    }





}
