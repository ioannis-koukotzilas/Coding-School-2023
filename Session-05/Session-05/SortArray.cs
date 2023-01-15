using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {

    /* Exercise 5. Write a C# program to sort the given array 
     * of integers from the lowest to the highest number. */

    internal class SortArray {

        public int[] GetArray() {

            Console.WriteLine("Given array in ascending order:");

            int[] arr = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };

            var sortArr = arr.OrderBy(n => n);

            foreach (int i in sortArr) {

                Console.Write(i + " ");

            }

            // TODO: Fix System.Int32[] console output

            return arr;

        }

    }

}
