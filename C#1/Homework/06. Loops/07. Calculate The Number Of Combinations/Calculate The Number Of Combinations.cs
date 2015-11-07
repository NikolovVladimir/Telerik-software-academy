//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements(also known as the number of combinations) is 
//calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k(1 < k<n< 100). Try to use only two loops.
//Examples:

//n k   n! / (k! * (n-k)!)
//3	2	3
//4	2	6
//10	6	210
//52	5	2598960


using System;
using System.Numerics;
class CalculateTheNumberOfCombinations
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number N and K(1 < k < n < 100):");
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (k >= i)
            {
                factorialK *= i;
            }
        }

        int result = (n - k);
        BigInteger factorialResult = 1;
        for (int j = 1; j <= result; j++)
        {
            factorialResult *= j;
        }

        Console.WriteLine(factorialN /(factorialK * factorialResult));
    }
}

