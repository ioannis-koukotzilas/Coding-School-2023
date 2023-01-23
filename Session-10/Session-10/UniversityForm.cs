using System.Xml.Linq;
using UniversityLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Session_10 {
    public partial class UniversityForm : Form {

        /* The entities of Students, Grades, Courses and ScheduledCourses 
         * (that belong to the University) should be populated with at least
         * 2 records each and displayed on separate Grid Controls. */

        private University _university;

        public UniversityForm() {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e) {
            PopulateData();
        }

        private void PopulateData() {

            // Top level object

            _university = new University() {
                UniversityName = "Aegean University"
            };

            // Lists

            List<Student> students = new List<Student>() {
                new Student("Ioannis Koukotzilas", 34, 444, _university.Courses),
                new Student("Marios Staikopoulos", 27, 777, _university.Courses),
            };
            
            
            List<Grade> grades = new List<Grade>() {

                new Grade() {
                    GradeNumber = 8
                },
                new Grade() {
                    GradeNumber = 10
                }

            };

            List<Course> courses = new List<Course>() {

                new Course() {
                    Code = "#RF",
                    Subject ="Recursive Function"
                },
                new Course() {
                    Code = "#DB",
                    Subject ="Data Binding"
                }

            };

            List<ScheduledCourse> scheduledCourses = new List<ScheduledCourse>() {

                new ScheduledCourse() {
                    Code = "#IN",
                    Subject = "Interfaces",
                    ExpectedDate = "February 2023"
                    
                },
                new ScheduledCourse() {
                    Code = "#BL",
                    Subject = "Blazor",
                    ExpectedDate = "February 2023"
                }

            };

            // Append objects list into university

            _university.Students = students;
            _university.Grades = grades;
            _university.ScheduledCourses = scheduledCourses;
            _university.Courses = courses;


            // Set datasources for grid view

            StudentsGrid.DataSource = students;
            GradesGrid.DataSource = grades;
            CoursesGrid.DataSource = courses;
            ScheduledCoursesGrid.DataSource = scheduledCourses;

        }

        // Serializer - export to JSON

        private void BtnSave_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "university.json");

            MessageBox.Show($"{_university.UniversityName} JSON export ready");

        }

        private void BtnLoad_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();
            _university = serializer.DeserializeFromFile<University>("university.json");

            MessageBox.Show($"{_university.UniversityName} JSON loaded");

        }
    }
}