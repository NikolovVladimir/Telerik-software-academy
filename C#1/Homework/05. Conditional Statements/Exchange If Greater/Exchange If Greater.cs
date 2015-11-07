//Problem 0
//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one.As a result print the values a and b, separated by a space.
//Examples:

//a b   result
//5	2	2 5
//3	4	3 4
//5.5	4.5	4.5 5.5

using System;


class Exchange_If_Greater
{
    static void Main()
    {
        Console.WriteLine("Emter two numbers:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double x = a + b;
            a = x - a;
            b = x - a;
            Console.WriteLine("{0} {1}", a, b);
        }
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

