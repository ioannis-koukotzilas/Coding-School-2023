namespace Session_09 {
    public partial class Calculator : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcuratorOperation _calculatorOperation;

        enum CalcuratorOperation {
            Addition
        }

        public Calculator() {
            InitializeComponent();
        }

        // EVENTS

        private void BtnAdditionClick(object sender, EventArgs e) {
            Monitor.Text += " + ";
            _calculatorOperation = CalcuratorOperation.Addition;
        }

        private void BtnEqualsClick(object sender, EventArgs e) {
            Monitor.Text += " = ";

            switch (_calculatorOperation) {
                case CalcuratorOperation.Addition:
                    _result = _value1 + _value2;
                    break;

                default:
                    break;
            }

            Monitor.Text += _result;
        }

        private void BtnOneClick(object sender, EventArgs e) {
            Monitor.Text += " 1 ";
            AssignValue(1);
        }

        private void BtnTwoClick(object sender, EventArgs e) {
            Monitor.Text += " 2 ";
            AssignValue(2);
        }

        // METHODS

        public void AssignValue(decimal i) {
            if (_value1 == null) {
                _value1 = i;
            } else {
                _value2 = i;
            }
        }


    }



}

