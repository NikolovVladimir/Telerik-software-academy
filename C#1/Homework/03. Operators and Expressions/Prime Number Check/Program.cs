//Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n(n ≤ 100) is prime(i.e.it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
//Examples:
//n Prime?
//1	false
//2	true
//3	true
//4	false
//9	false
//97	true
//51	false
//-3	false
//0	false

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter positive integer number n between 1 and 100");
        int n = int.Parse(Console.ReadLine());
        bool prime = false;
        if (n <= 1)
        {
            Console.WriteLine("{0} is not a prime", n);
            prime = true;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("{0} is not a prime", n);
                prime = true;
                break;
            }
        }
        if (prime == false)
        {
            Console.WriteLine("{0} is prime", n);
        }
    }
}