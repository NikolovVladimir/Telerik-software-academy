﻿//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
//Examples:

//n binary representation bit #3
//5	00000000 00000101	0
//0	00000000 00000000	0
//15	00000000 00001111	1
//5343	00010100 11011111	1
//62241	11110011 00100001	0

using System;

class bitwiseExtractBit3
{
    static void Main()
    {
        Console.WriteLine("Enter a integer number:");
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit);
    }
}

