namespace Session_10 {
    public partial class UniversityForm : Form {

        private University _university;

        public UniversityForm() {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e) {

            University university = new University() {
              Name = "Aegean University"
            };

            List<Student> students = new List<Student>() {

                new Student() {
                    RegistrationNumber = 1,
                    Name = "Ioannis",
                    Surname = "Koukotzilas",
                    Age = 34, 
                },

                 new Student() {
                    RegistrationNumber = 2,
                    Name = "Eftichia",
                    Surname = "Makri",
                    Age = 27,
                }

            };

            university.Students = students;

            StudentsGrid.DataSource = students;

            List<Grade> grades = new List<Grade>() {

                new Grade() {
                  
                },

            };

            GradesGrid.DataSource = grades;

            List<Course> courses = new List<Course>() {

                new Course() {

                },

            };

            university.Grades = grades;

            CoursesGrid.DataSource = courses;

            List<ScheduledCourse> scheduledCourses = new List<ScheduledCourse>() {

                new ScheduledCourse() {

                },

            };

            ScheduledCoursesGrid.DataSource = scheduledCourses;


          


           



        }

        private void BtnSave_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "university.json");

            MessageBox.Show("JSON ready!");

        }

        private void BtnLoad_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();
            _university = serializer.DeserializeFromFile<University>("university.json");

        }
    }
}