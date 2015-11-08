//Problem 1. Odd or Even Integers
//Write an expression that checks if given integer is odd or even.
//Examples:
//n Odd?
//3	true
//2	false
//-2	false
//-1	true
//0	false

using System;

class Odd_or_Even_Integers
{
    static void Main()
    {
        Console.WriteLine("Write a integer number");
        int number = int.Parse(Console.ReadLine());
        bool check = ((number % 2) != 0);
        Console.WriteLine("Is the number odd?");
        Console.WriteLine(check);

    }
}
