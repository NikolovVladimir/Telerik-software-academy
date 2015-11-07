//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends* at the end.
//Print the result at the console. Use switch statement.
//Example 1:

//program user
//Please choose a type:	
//1 --> int
//2 --> double
//3 --> string    3
//Please enter a string:	hello
//hello*	
//Example 2:

//program user
//Please choose a type:	
//1 --> int
//2 --> double    2
//3 --> string
//Please enter a double:	1.5
//2.5

using System;


namespace Play_with_Int__Double_and_String
{
    class Play_with_Int__Double_and_String
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Please enter a intiger:");
                int firstChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoice + 1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Please enter a double:");
                double secondChoice = double.Parse(Console.ReadLine());
                Console.WriteLine(secondChoice + 1);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Please enter a string:");
                string thirdChoice = Console.ReadLine();
                Console.WriteLine("{0}*", thirdChoice);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}
