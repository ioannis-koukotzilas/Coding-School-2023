﻿using System;
using Session_05;

internal class Program {

    private static void Main(string[] args) {

        /* Exercise 1. Reverse string. */

        ReverseString exerOne = new ReverseString();

        Console.WriteLine(exerOne.GetStringForLoop());
        Console.WriteLine(exerOne.GetStringForeachLoop());
        Console.WriteLine(exerOne.GetStringArrayReverse());
        Console.WriteLine(exerOne.GetUserInput());


        Console.ReadLine();

    }

}