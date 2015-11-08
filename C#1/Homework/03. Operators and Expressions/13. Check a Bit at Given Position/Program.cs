//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
//n binary representation of n p   bit @ p == 1
//5	00000000 00000101	2	true
//0	00000000 00000000	9	false
//15	00000000 00001111	1	true
//5343	00010100 11011111	7	true
//62241	11110011 00100001	11	false


using System;

class Check_a_Bit_at_Given_Position
{
    static void Main()
    {
        Console.WriteLine("Enter a integer number:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter position:");
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool check = bit == 1;
        Console.WriteLine(check);
    }
}

