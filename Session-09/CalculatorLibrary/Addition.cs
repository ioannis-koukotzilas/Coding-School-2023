namespace CalculatorLibrary {

    public class Addition {

        public decimal Calculate(decimal? x, decimal? y) {

            decimal result = 0;

            if (x != null && y != null) {
                // TODO: Ask where value is coming from?
                result = x.Value + y.Value;
            }

            return result;
        }

    }

    public class Subtraction {

        public decimal Calculate(decimal? x, decimal? y) {

            decimal result = 0;

            if (x != null && y != null) {
                result = x.Value - y.Value;
            }

            return result;
        }

    }

    public class Multiplication {

        public decimal Calculate(decimal? x, decimal? y) {

            decimal result = 0;

            if (x != null && y != null) {
                result = x.Value * y.Value;
            }

            return result;
        }

    }

    public class Division {

        public decimal Calculate(decimal? x, decimal? y) {

            decimal result = 0;

            if (x != null && y != null) {
                result = x.Value / y.Value;
            }

            return result;
        }

    }

    public class RaiseToPower {

        public decimal Calculate(decimal? x, decimal? y) {

            decimal result = 0;

            if (x != null && y != null) {
                result = (decimal)Math.Pow((double)x.Value, (double)y.Value);
            }

            return result;
        }

    }

    public class SquareRoot {

        public decimal Calculate(decimal? x) {

            decimal result = 0;

            if (x != null) {
                result = (decimal)Math.Sqrt((double)x.Value);

            }

            return result;
        }

    }

}