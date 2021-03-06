﻿//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point).
//The input starts by the number n(alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.
//Example 1:

//input output
//3 
//2 
//5 
//1	    min = 1
//      max = 5
//      sum = 8
//      avg = 2.67
//Example 2:

//input output
//2 
//-1 
//4	    min = -1
//      max = 4
//      sum = 3
//      avg = 1.50

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter how many numbers do you want to use:");
        int numberOfLines = int.Parse(Console.ReadLine());
        int []numbers = new int[numberOfLines];
        int sum = 0;
        int max = 0;
        int min = 0;
        for (int i = 0; i < numberOfLines; i++)
        {
            Console.WriteLine("Enter a number:");
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
            min = numbers[i];
            if (min > numbers[i])
            {
                min = numbers[i];
            }
            else if (max < numbers[i])
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("The minimal number is: {0}", min);
        Console.WriteLine("The maximal number is: {0}", max);
        Console.WriteLine("The sum of the numbers is: {0}", sum);
        Console.WriteLine("The average of all numbers is: {0:f2}", (double)sum/numberOfLines);



    }
}
