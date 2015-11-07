//Problem 4. Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:
//width height  perimeter area
//3	   4	    14	    12
//2.5  3	    11	    7.5
//5	   5	    20	    25

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Write the width of the rectangle:");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Write the height of the rectangle:");
        float height = float.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is {0}", (width + height) * 2);
        Console.WriteLine("The area of the rectangle is {0}", (width * height));
    }
}
