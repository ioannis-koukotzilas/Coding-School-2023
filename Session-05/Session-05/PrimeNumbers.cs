using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {

    /* Write a C# program that asks the user for an integer (n) 
     * and finds all the prime numbers from 1 to n. */

    internal class PrimeNumbers {

        public int GetUserInput() {

            Console.WriteLine("Enter a number to find prime numbers:");

            int n;
            string? str = Console.ReadLine();
            bool canConvert = int.TryParse(str, out n);

            if (str != null && canConvert == true) {

                Console.WriteLine($"Prime numbers from 1 to {str} are:");

                bool isPrime = true;

                for (int i = 2; i <= n; i++) {

                    for (int j = 2; j <= n; j++) {

                        if (i != j && i % j == 0) {

                            isPrime = false;

                            break;

                        }

                    }

                    if (isPrime) {

                        Console.Write(i + " ");

                    }

                    isPrime = true;

                }

            } else {

                Console.WriteLine("You have not entered a number");

            }

            // TODO: What should I return here?

            return 0;

        }

    }

}
