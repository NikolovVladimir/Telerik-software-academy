//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//Examples:

//a b   h area
//5	7	12	72
//2	1	33	49.5
//8.5	4.3	2.7	17.28
//100	200	300	45000
//0.222	0.333	0.555	0.1540125


using System;




    class trapezoids

    {
        static void Main()
        {
        Console.WriteLine("Write side a of the trapezoid:");
        float sideA = float.Parse(Console.ReadLine());
        Console.WriteLine("Write side b of the trapezoid:");
        float sideB = float.Parse(Console.ReadLine());
        Console.WriteLine("Write the height of the trapezoid:");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("The area of the trapezoid is {0}", ((sideA + sideB) / 2) * height);
    }
    }

