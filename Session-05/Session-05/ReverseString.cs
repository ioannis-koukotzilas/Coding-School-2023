using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {

    /* Exercise 1. Write a C# program that reverses a given string (your name). */

    internal class ReverseString {

        public string GetString() {

            string str = "Ioannis Koukotzilas";

            string revStr = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--) {

                revStr += str[i];

            }

            string output = $"Reversed string of '{str}' is '{revStr}'.";

            return output;

        }


    }

}
