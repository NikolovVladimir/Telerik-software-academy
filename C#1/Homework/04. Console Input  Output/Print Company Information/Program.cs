//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager.The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:

//program user
//Company name:	Telerik Academy
//Company address:	31 Al.Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	
//Web site:	http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	25
//Manager phone:	+359 2 981 981
//Example output:

//Telerik Academy
//Address: 231 Al.Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov(age: 25, tel. +359 2 981 981)

using System;



class Print_Company_Information
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your company data:");
        string companyName = Console.ReadLine();
        string companyAdress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string fax = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        string managerAge = Console.ReadLine();
        string managerPhone = Console.ReadLine();
        Console.WriteLine("Company name: {0}\nAdress:{1}\nTel: {2}\nFax: {3}\nWeb site:{4}\nManager: {5} {6}(age: {7}, tel. {8})", 
            companyName, companyAdress, phoneNumber, webSite, fax, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
