//Problem 1. Declare Variables
//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it.Try to compile the code.

using System;

class declareVariables
{
    static void Main()
    {
        byte variableByte = 97;
        sbyte variableSbyte = -115;
        short variableShort = -10000;
        ushort variableUshort = 52130;
        int variablerInt = 4825932;
        Console.WriteLine("Byte variable is {0}, sbyte variable is {1}, short variable is {2}, ushort variable is {3} and int variable is {4}.",
            variableByte, variableSbyte, variableShort, variableUshort, variablerInt);
    }
}

