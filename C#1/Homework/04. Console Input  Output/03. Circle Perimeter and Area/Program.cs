//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
//Examples:

//r perimeter   area
//2	12.57	12.57
//3.5	21.99	38.48

using System;


class Circle_Perimeter_and_Area
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of a circle:");
        double radius = double.Parse(Console.ReadLine());
        double areaCircle = (radius * radius) * Math.PI;
        double perimeter = 2 * (radius * Math.PI);
        Console.WriteLine("The perimeter of the circle is - {0,15:f2}\nThe area of the circle is - {1,20:f2}", perimeter, areaCircle);
    }
}