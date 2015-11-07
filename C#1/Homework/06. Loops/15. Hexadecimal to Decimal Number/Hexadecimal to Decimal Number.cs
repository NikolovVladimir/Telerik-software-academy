//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//hexadecimal	decimal
//FE	254
//1AE3	6883
//4ED528CBB4	338583669684

using System;

class hexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal integer:");
        string input = Console.ReadLine();
        long decimalNum = 0;
        long multiplier = 1;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            int numberFromHex;

            switch (input[i])
            {
                case 'A':
                    numberFromHex = 10; break;
                case 'B':
                    numberFromHex = 11; break;
                case 'C':
                    numberFromHex = 12; break;
                case 'D':
                    numberFromHex = 13; break;
                case 'E':
                    numberFromHex = 14; break;
                case 'F':
                    numberFromHex = 15; break;

                default: numberFromHex = input[i] - 48;
                    break;
            }
            decimalNum += numberFromHex * multiplier;
            multiplier *= 16;
        }
        Console.WriteLine(decimalNum);

    }
}
