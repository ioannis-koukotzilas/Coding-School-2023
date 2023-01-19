using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary {

    public class RaiseToPower {

        public decimal Calculate(decimal? x, decimal? y) {

            decimal result = 0;

            if (x != null && y != null) {
                result = (decimal)Math.Pow((double)x.Value, (double)y.Value);
            }

            return result;
        }

    }

}