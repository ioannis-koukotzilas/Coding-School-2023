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

}