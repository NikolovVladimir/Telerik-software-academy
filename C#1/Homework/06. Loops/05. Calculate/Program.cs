﻿//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop.Print the result with 5 digits after the decimal point.
//Examples:

//n x   S
//3	2	2.75000
//4	3	2.07407
//5	-4	0.75781

using System;

class Calculate
{
    static void Main()
    {
        Console.WriteLine("Enter intiger n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter intiger x:");
        int x = int.Parse(Console.ReadLine());

        double power = 1;
        double sum = 1;
        double faktorial = 1;

        for (int i = 1; i <= n; i++)
        {
            faktorial *= i;
            power = power * x;
            sum += faktorial / power;
        }
        Console.WriteLine("{0:f5}", sum);
    }
}
