using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05 {

    /* Exercise 4. Write a C# program to multiply all values from Array1 
     * with all values from Array2 and display the results in a new Array. */

    internal class MultiplyArrays {

        public int[] GetArrays() {

            Console.WriteLine("Arrays multiplication:");

            int[] arr1 = { 2, 4, 9, 12 };

            int[] arr2 = { 1, 3, 7, 10 };

            int[] arr3 = new int[16];

            for (int i = 0; i < arr1.Length; i++) {

                for (int j = 0; j < arr2.Length; j++) {

                    arr3[j] = arr1[i] * arr2[j];

                    Console.Write(arr3[j] + " ");

                }

            }

            // TODO: Fix System.Int32[] console output

            return arr3;

        }

    }

}
