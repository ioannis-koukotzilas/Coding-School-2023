using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {

    /* Exercise 1. Write a C# program that reverses a given string (your name).
     * Different methods written for learning purposes.
     * In real life we should use one of these. */

    internal class ReverseString {

        // Using for loop.

        public string GetStringForLoop() {

            string str = "Ioannis Koukotzilas";

            string revStr = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--) {

                revStr += str[i];

            }

            string output = $"Reversed string of '{str}' is '{revStr}'.";

            return output;

        }

        // Using foreach loop.

        public string GetStringForeachLoop() {

            string str = "Ioannis Koukotzilas";

            string revStr = string.Empty;

            foreach (char c in str) {

                revStr = c + revStr;

            }

            string output = $"Reversed string of '{str}' is '{revStr}'.";

            return output;

        }

        // Using built-in array reverse method.

        public string GetStringArrayReverse() {

            string str = "Ioannis Koukotzilas";

            char[] c = str.ToCharArray();

            Array.Reverse(c);

            string revStr = new string(c);

            string output = $"Reversed string of '{str}' is '{revStr}'.";

            return output;

        }

        // User input string.

        public string? GetUserInput() {

            Console.Write("Enter your name: ");

            string? str = Console.ReadLine();

            if (str != null) {

                string revStr = string.Empty;

                for (int i = str.Length - 1; i >= 0; i--) {

                    revStr += str[i];

                }

                string output = $"Reversed string of '{str}' is '{revStr}'.";

                return output;

            } else {

                return null;

            }

        }

    }

}
