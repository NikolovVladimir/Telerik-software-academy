//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers(given in a single line, separated by a space), calculates and prints their sum.
//Examples:

//numbers sum
//1 2 3 4 5	15
//10 10 10 10 10	50
//1.5 3.14 8.2 -1 0	11.84

using System;

class Sum_of_5_Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers divided by space:");
        string[] numbers = Console.ReadLine().Split();
        double a = double.Parse(numbers[0]);
        double b = double.Parse(numbers[1]);
        double c = double.Parse(numbers[2]);
        double d = double.Parse(numbers[3]);
        double e = double.Parse(numbers[4]);
        Console.WriteLine("The sum of the numbers is: {0}", a + b + c + d + e);
    }
}

