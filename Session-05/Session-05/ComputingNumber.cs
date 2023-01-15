using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {

    /* Exercise 2. Write a C# program that asks the user for an integer (n) 
     * and gives them the possibility to choose between computing the sum 
     * and computing the product of 1,...,n. */

    internal class ComputingNumber {

        public bool GetNumber() {

            int i;
            int n;
            int sum = 0;
            int prod = 1;

            Console.WriteLine("Enter a number to compute: ");

            n = Convert.ToInt32(Console.ReadLine());

            // TODO: Make boolean selectable from console

            bool isSum = true;

            if (isSum) {

                for (i = 1; i <= n; i++) {

                    sum += i;

                }

                Console.WriteLine("Total sum is: " + sum);

            } else {

                for (i = 1; i <= n; i++) {

                    prod *= i;

                }

                Console.WriteLine("Total product is: " + prod);

            }

            return true;

        }

    }

}
