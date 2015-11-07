//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range[1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:

//score result
//2	20
//4	400
//9	9000
//-1	invalid score
//10	invalid score

using System;

class Bonus_Score
{
    static void Main()
    {
        Console.WriteLine("Enter score:");
        int score = int.Parse(Console.ReadLine());

        if (score <= 0)
        {
            Console.WriteLine("Invalid score!");
        }

        else if (score <= 3)
        {
            Console.WriteLine(score * 10);
        }

        else if (score <= 6)
        {
            Console.WriteLine(score * 100);
        }

        else if (score <= 9)
        {
            Console.WriteLine(score * 1000);
        }

        else if (score > 9)
        {
            Console.WriteLine("Invalid score!");
        }
       
    }
}
