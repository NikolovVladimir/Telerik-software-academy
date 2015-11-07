//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal hexadecimal
//254	FE
//6883	1AE3
//338583669684	4ED528CBB4

using System;

class decimaltoHexadecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter an integer number:");
        long input = long.Parse(Console.ReadLine());
        long remainder;
        string hexadecimal = "";
        while (input > 0)
        {
            remainder = input / 16;

            long hexNumber = input - (remainder * 16);

            if (input / 16 == 0)
            {
                hexNumber = input;
            }
            input = remainder;

            switch (hexNumber)
            {
                case 10:
                    hexadecimal = ("A" + hexadecimal).ToString();
                    break;
                case 11:
                    hexadecimal = ("B" + hexadecimal).ToString();
                    break;
                case 12:
                    hexadecimal = ("C" + hexadecimal).ToString();
                    break;
                case 13:
                    hexadecimal = ("D" + hexadecimal).ToString();
                    break;
                case 14:
                    hexadecimal = ("E" + hexadecimal).ToString();
                    break;
                case 15:
                    hexadecimal = ("F" + hexadecimal).ToString();
                    break;
                default:
                    hexadecimal = (hexNumber + hexadecimal).ToString();
                    break;
            }
        }
        Console.WriteLine(hexadecimal);
    }
}
