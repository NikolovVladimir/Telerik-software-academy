//Problem 11. Bank Account Data
//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names

using System;

    class bankAccountData
{
        static void Main()
        {
        string accHolderName = "Vladimir Dimitrov Nikolov";
        decimal moneyBalance = 1000.54m;
        string bankName = "VLADIMIR D NIKOLOV";
        object IBAN = "BG80 BNBG 9661 1020 3456 78";
        long visa = 4111111111111111;
        long masterCard = 5105105105105100;
        long americanExpress = 378282246310005;
        Console.WriteLine ("Client Name: {0}\nBalance: {1}\nBank Name: {2}\nIBAN: {3}\nVisa number: {4}\nMasterCard number{5}American Express number: {6}", 
            accHolderName, moneyBalance, bankName, IBAN, visa, masterCard, americanExpress);
        }
    }

