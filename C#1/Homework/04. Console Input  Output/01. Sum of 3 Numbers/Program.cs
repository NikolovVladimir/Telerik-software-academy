﻿//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.
//Examples:

//a b   c sum
//3	4	11	18
//-2	0	3	1
//5.5	4.5	20.1	30.1

using System;



class Sum_of_3_Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entetr three real numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the numbers is: {0}", a + b + c);
    }
}

