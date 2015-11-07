//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//binary  decimal
//0	0
//11	3
//1010101010101011	43691
//1110000110000101100101000000	236476736

using System;


class binaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number in binary:");
        string input = Console.ReadLine();
        long decimalNum = 0;
        foreach (char num in input)
        {
            string numberFromInput = num.ToString();
            int a = int.Parse(numberFromInput);
            decimalNum = (decimalNum * 2 + a);
        }
        Console.WriteLine(decimalNum);
    }
}
