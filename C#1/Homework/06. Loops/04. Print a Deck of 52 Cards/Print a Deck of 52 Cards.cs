//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards(without the jokers). The cards should be printed using the classical notation(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades.Use 2 nested for-loops and a switch-case statement.

using System;


namespace PrintADeckOf52Cards
{
    class Program
    {
        static void Main()
        {
            string[] frenchSuits = new string[4] { "spades, ", "clubs, ", "hearts, ", "diamonds" };
            string[] cards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = 0; j < frenchSuits.Length; j++)
                {
                    switch (i)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            Console.Write("{0} of {1}", cards[i], frenchSuits[j]);
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}