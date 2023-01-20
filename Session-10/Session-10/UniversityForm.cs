namespace Session_10 {
    public partial class UniversityForm : Form {
        public UniversityForm() {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e) {

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

            StudentsGrid.DataSource = students;



        }
    }
}