//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
//Examples:

//n output
//3	1 2 3
//5	1 2 3 4 5

using System;

class Numbers_from_1_to_N
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number:");
        int number = int.Parse(Console.ReadLine());
        int counter = 1;
        while (counter <= number)
        {
            Console.Write("{0} ", counter);
            counter++;
        }
        Console.WriteLine();
    }
}

