using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {
    public class SumDivision {

        public string Calculate() {

            /* Write a C# program that takes an integer representing seconds (for example 45678) 
             */

            int numberA = 1989;
            int numberB = 34;

            int sum = numberA + numberB;
            int division = numberA / numberB;

            string message = "The SUM of the two numbers is: " + sum + ". The division is: " + division + ".";

            return message;

        }

    }

}
