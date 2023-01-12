using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {

    public class SpecifiedOperations {

        /* Write a C# program to print the result of the specified operations
         */

        // TODO: Review the results

        public int OperationOne() {
            int result = (-1 + 5) * 6;
            return result;
        }

        public double OperationTwo() {
            double result = 38 + 5 % 7;
            return result;
        }

        public double OperationThree() {
            double result = 14.00 + (-3.00 * 6.00) / 7.00;
            return result;
        }

        public double OperationFour() {
            double result = (2.00 + 13.00 / 6.00) * 6.00 ;
            return result;
        }

        public double OperationFive() {
            double result = (6 * 6 * 6 * 6) + (5 * 5 * 5 * 5 * 5 * 5 * 5) / (9 % 4);
            return result;
        }

    }

}
