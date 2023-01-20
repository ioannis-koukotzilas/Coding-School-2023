namespace Session_10 {
    public partial class UniversityForm : Form {
        public UniversityForm() {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e) {

            List<Student> students = new List<Student>();

            Student student1 = new Student() {

                Name = "Ioannis",
                Age = 34


            };

        }
    }
}