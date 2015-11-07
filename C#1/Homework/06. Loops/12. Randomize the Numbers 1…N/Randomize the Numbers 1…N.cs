//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:

//n randomized numbers 1…n
//3	2 1 3
//10	3 4 8 2 6 7 9 1 10 5

using System;

    class randomizeTheNumbers1toN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        bool[] printed = new bool[n + 1];
        Random randomNum = new Random();

        for (int i = 1; i <= n; i++)
        {
            int numberToPrint = randomNum.Next(1, n + 1);

            if (!printed[numberToPrint])
            {
                Console.Write("{0} ", numberToPrint);
                printed[numberToPrint] = true;
            }
            else
            {
                i--;
            }
        }
    }
}


