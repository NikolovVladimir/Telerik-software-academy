//Problem 2. Float or Double?
//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class floatOrDouble

{
    static void Main(string[] args)
    {
        float number1 = 12.345f;
        float number2 = 3456.091f;
        double number3 = 8923.1234857;
        double number4 = 34.567839023;
        Console.WriteLine("{0}, {1}, {2}, {3}", number1, number2, number3, number4);
    }
}
