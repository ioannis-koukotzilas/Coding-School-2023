using System;
using Session_05;

internal class Program {

    private static void Main(string[] args) {

        /* Exercise 1. Reverse string. */

        ReverseString exerOne = new ReverseString();

        Console.WriteLine(exerOne.GetStringForLoop());
        Console.WriteLine(exerOne.GetStringForeachLoop());
        Console.WriteLine(exerOne.GetStringArrayReverse());
        Console.WriteLine(exerOne.GetUserInput());

        /* Exercise 2. Computing number. */

        ComputingNumber exerTwo = new ComputingNumber();

        Console.WriteLine(exerTwo.GetNumber());

        /* Exercise 3. Prime numbers. */

        PrimeNumbers exerThree = new PrimeNumbers();

        Console.WriteLine(exerThree.GetUserInput());

        /* Exercise 4. Multiply arrays. */

        MultiplyArrays exerFour = new MultiplyArrays();

        Console.WriteLine(exerFour.GetArrays());


        Console.ReadLine();

    }

}