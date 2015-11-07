//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal binary
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000

using System;

class decimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        long input = long.Parse(Console.ReadLine());
        string binary = "";
        if (input == 0)
        {
            Console.WriteLine(0);
            return;
        }
        while (input > 0)
        {
            if (input % 2 != 0)
            {
                binary = (1 + binary).ToString();
            }
            else
            {
                binary = (0 + binary).ToString();
            }
            input = input / 2;
        }
        //char[] reversedBinary = binary.ToCharArray();
        //Array.Reverse(reversedBinary);
        //new string(reversedBinary);
        Console.WriteLine(binary);
    }

}




