using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary {

    public class Multiplication {

        public decimal Calculate(decimal? x, decimal? y) {

            decimal result = 0;

            if (x != null && y != null) {
                result = x.Value * y.Value;
            }

            return result;
        }

    }

}
