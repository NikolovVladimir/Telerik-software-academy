//Problem 10. Odd and Even Product

//You are given n integers(given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:

//numbers result
//2 1 1 6 3	yes
//product = 6	
//3 10 4 6 5 1	yes
//product = 60	
//4 3 2 5 2	no
//odd_product = 16
//even_product = 15

using System;

class oddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter some interger numbers in a single line, separated by space:");
        string[] numbers = Console.ReadLine().Split();
        int positive = 1;
        int odd = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            int a = int.Parse(numbers[i]);
            if (i % 2 == 0)
            {
                odd *= a;
            }
            else
            {
                positive *= a;
            }
        }
        if (positive == odd)
        {
            Console.WriteLine("Yes! Product={0}", positive);

        }
        else
        {
            Console.WriteLine("No! oddProduct={0}, evenProduct={1}", odd, positive);
        }
    }
}


