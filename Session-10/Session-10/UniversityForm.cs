namespace Session_10 {
    public partial class UniversityForm : Form {
        public UniversityForm() {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e) {

            List<Student> students = new List<Student>() {

                new Student() {
                    Name = "Ioannis",
                    Age = 34
                },

                 new Student() {
                    Name = "Eftichia",
                    Age = 34
                }

            };

            StudentsGrid.DataSource = students;

      

        }
    }
}