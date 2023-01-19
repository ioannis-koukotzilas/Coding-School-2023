using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary {

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
