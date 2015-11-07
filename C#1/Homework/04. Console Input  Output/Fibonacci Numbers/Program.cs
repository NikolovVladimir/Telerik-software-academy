//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

//Examples:

//n comments
//1	0
//3	0 1 1
//10	0 1 1 2 3 5 8 13 21 34

using System;

class Fibonacci_Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter an number where the Fibonacci sequence to stop:");
        int n = int.Parse(Console.ReadLine());


        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else

        {
            int firstFibNum = 0;
            Console.Write("{0}, ", firstFibNum);

            int secondFibNum = 1;
            Console.Write("{0}, ", secondFibNum);

            int sum = 0;

            for (int i = 2; i < n; i++)
            {
                sum = firstFibNum + secondFibNum;
                Console.Write("{0}, ", sum);

                firstFibNum = secondFibNum;
                secondFibNum = sum;

            }
            Console.WriteLine();
        }
    }
}
