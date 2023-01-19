using CalculatorLibrary;

namespace Session_09 {
    public partial class Calculator : Form {

        private decimal? _value1 = null;
        private decimal? _value2 = null;
        private decimal? _result = null;

        private CalcuratorOperation _calculatorOperation;

        enum CalcuratorOperation {
            Addition,
            Subtraction,
            Multiplication,
            Division,
            RaiseToPower,
            SquareRoot
        }

        public Calculator() {
            InitializeComponent();
        }

        // METHODS 

        public void AssignValue(decimal i) {
            if (_value1 == null) {
                _value1 = i;
            } else {
                _value2 = i;
            }
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
                    //_result = _value1 + _value2;
                    Addition addition = new Addition();
                    _result = addition.Calculate(_value1, _value2);
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

        private void BtnThreeClick(object sender, EventArgs e) {
            Monitor.Text += " 3 ";
            AssignValue(3);
        }

        private void BtnFourClick(object sender, EventArgs e) {
            Monitor.Text += " 4 ";
            AssignValue(4);
        }

        private void BtnFiveClick(object sender, EventArgs e) {
            Monitor.Text += " 5 ";
            AssignValue(5);
        }

        private void BtnSixClick(object sender, EventArgs e) {
            Monitor.Text += " 6 ";
            AssignValue(6);
        }

        private void BtnSevenClick(object sender, EventArgs e) {
            Monitor.Text += " 7 ";
            AssignValue(7);
        }

        private void BtnEightClick(object sender, EventArgs e) {
            Monitor.Text += " 8 ";
            AssignValue(8);
        }

        private void BtnNineClick(object sender, EventArgs e) {
            Monitor.Text += " 9 ";
            AssignValue(9);
        }
    }



}

