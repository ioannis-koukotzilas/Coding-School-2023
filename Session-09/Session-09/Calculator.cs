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


        // TODO: Clear monitor needs improvements
        public void ClearMonitor() {
            if (_result != null) {
                Monitor.Text = string.Empty;
                _value1 = null;
                _value2 = null;
                _result = null;
            }
        }

        // OPERATIONS EVENTS

        private void BtnAdditionClick(object sender, EventArgs e) {
            Monitor.Text += " + ";
            _calculatorOperation = CalcuratorOperation.Addition;
            ClearMonitor();
        }

        private void BtnSubtractionClick(object sender, EventArgs e) {
            Monitor.Text += " - ";
            _calculatorOperation = CalcuratorOperation.Subtraction;
            ClearMonitor();
        }

        private void BtnMultiplicationClick(object sender, EventArgs e) {
            Monitor.Text += " x ";
            _calculatorOperation = CalcuratorOperation.Multiplication;
            ClearMonitor();
        }

        private void BtnDivisionClick(object sender, EventArgs e) {
            Monitor.Text += " ÷ ";
            _calculatorOperation = CalcuratorOperation.Division;
            ClearMonitor();
        }

        private void BtnRaiseToPowerClick(object sender, EventArgs e) {
            Monitor.Text += " n2 ";
            _calculatorOperation = CalcuratorOperation.RaiseToPower;
            ClearMonitor();
        }

        private void BtnSquareRootClick(object sender, EventArgs e) {
            Monitor.Text += " √ ";
            _calculatorOperation = CalcuratorOperation.SquareRoot;
            ClearMonitor();
        }

        private void BtnEqualsClick(object sender, EventArgs e) {
            Monitor.Text += " = ";

            switch (_calculatorOperation) {
                case CalcuratorOperation.Addition:
                    //_result = _value1 + _value2;
                    Addition addition = new Addition();
                    _result = addition.Calculate(_value1, _value2);
                    break;
                case CalcuratorOperation.Subtraction:
                    //_result = _value1 - _value2;
                    Subtraction subtraction = new Subtraction();
                    _result = subtraction.Calculate(_value1, _value2);
                    break;
                case CalcuratorOperation.Multiplication:
                    //_result = _value1 * _value2;
                    Multiplication multiplication = new Multiplication();
                    _result = multiplication.Calculate(_value1, _value2);
                    break;
                case CalcuratorOperation.Division:
                    //_result = _value1 / _value2;
                    Division division = new Division();
                    _result = division.Calculate(_value1, _value2);
                    break;
                case CalcuratorOperation.RaiseToPower:
                    //_result = _value1 ^ _value2;
                    RaiseToPower raiseToPower = new RaiseToPower();
                    _result = raiseToPower.Calculate(_value1, _value2);
                    break;
                case CalcuratorOperation.SquareRoot:
                    //_result = _value1 √;
                    SquareRoot squareRoot = new SquareRoot();
                    _result = squareRoot.Calculate(_value1);
                    break;

                default:
                    break;
            }

            Monitor.Text += _result;
  
        }

        // NUMBERS EVENTS

        private void BtnOneClick(object sender, EventArgs e) {
            Monitor.Text += " 1 ";
            AssignValue(1);
            ClearMonitor();
        }

        private void BtnTwoClick(object sender, EventArgs e) {
            Monitor.Text += " 2 ";
            AssignValue(2);
            ClearMonitor();
        }

        private void BtnThreeClick(object sender, EventArgs e) {
            Monitor.Text += " 3 ";
            AssignValue(3);
            ClearMonitor();
        }

        private void BtnFourClick(object sender, EventArgs e) {
            Monitor.Text += " 4 ";
            AssignValue(4);
            ClearMonitor();
        }

        private void BtnFiveClick(object sender, EventArgs e) {
            Monitor.Text += " 5 ";
            AssignValue(5);
            ClearMonitor();
        }

        private void BtnSixClick(object sender, EventArgs e) {
            Monitor.Text += " 6 ";
            AssignValue(6);
            ClearMonitor();
        }

        private void BtnSevenClick(object sender, EventArgs e) {
            Monitor.Text += " 7 ";
            AssignValue(7);
            ClearMonitor();
        }

        private void BtnEightClick(object sender, EventArgs e) {
            Monitor.Text += " 8 ";
            AssignValue(8);
            ClearMonitor();
        }

        private void BtnNineClick(object sender, EventArgs e) {
            Monitor.Text += " 9 ";
            AssignValue(9);
            ClearMonitor();
        }

    }

}

