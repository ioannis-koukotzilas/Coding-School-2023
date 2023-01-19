namespace Session_09 {
    public partial class Calculator : Form {
        public Calculator() {
            InitializeComponent();
        }

        private void BtnAdditionClick(object sender, EventArgs e) {
            Monitor.Text= " + ";
        }

        private void BtnEqualsClick(object sender, EventArgs e) {
            Monitor.Text = " = ";
        }

        private void BtnOneClick(object sender, EventArgs e) {
            Monitor.Text = " 1 ";
        }

        private void BtnTwoClick(object sender, EventArgs e) {
            Monitor.Text = " 2 ";
        }
    }
}