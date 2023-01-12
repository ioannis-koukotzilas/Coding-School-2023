using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04 {

    internal class CelsiusConverter {

        public string GetDegrees() {

            /* Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
             */

            double CelsiusDegrees = 27.00;
            double KelvinDegrees = CelsiusDegrees + 273.15;
            double FahrenheitDegrees = CelsiusDegrees * 9 / 5 + 32;

            string message = CelsiusDegrees + " Celsius degrees are " + KelvinDegrees + " Kelvin degrees or " + FahrenheitDegrees + " Fahrenheit degrees.";

            return message;

        }

    }

}
