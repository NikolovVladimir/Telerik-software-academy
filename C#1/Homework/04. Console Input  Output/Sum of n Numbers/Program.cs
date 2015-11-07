﻿//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.Note: You may need to use a for-loop.
//Examples:

//numbers sum
//3	        90
//20	
//60	
//10	
//5	        6.5
//2	
//-1	
//-0.5	
//4	
//2	
//1	            1
//1

using System;

class Sum_of_n_Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number of numbers:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} more numbers:",n);
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine("{0}", sum);
    }
}

