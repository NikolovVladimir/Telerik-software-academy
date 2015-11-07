//Problem 12. Null Values Arithmetic
//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

class nullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? nullValueInt = null;
        double? nullValueDouble = null;
        Console.WriteLine("{0}\n{1}", nullValueInt, nullValueDouble);
        nullValueInt = 5;
        nullValueDouble = 10;
        Console.WriteLine("{0}\n{1}", nullValueInt, nullValueDouble);
    }
}
