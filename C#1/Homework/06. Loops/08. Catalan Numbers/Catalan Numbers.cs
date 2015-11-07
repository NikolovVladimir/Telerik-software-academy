//Catalan Numbers
// (2n)!/(n+1)!n!
//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n(0 ≤ n ≤ 100).
//Examples:

//n Catalan(n)
//0	1
//5	42
//10	16796
//15	9694845

using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number N (0 <= n <= 100):");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialNPlusOne = 1;
        BigInteger factorialTwoTimesN = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            factorialTwoTimesN *= i;
            if (i <= n + 1)
            {
                factorialNPlusOne *= i;
            }
            if (i <= n)
            {
                factorialN *= i;
            }
        }
        Console.WriteLine(factorialTwoTimesN/(factorialNPlusOne * factorialN));
    }
}

