//Problem 10. Employee Data
//A marketing company wants to keep record of its employees.Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender(m or f)
//Personal ID number(e.g. 8306112507)
//Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.Use descriptive names.
//Print the data at the console.

using System;


class employeeData
{
    static void Main()
    {
        string firstName = "Vladimir";
        string lastName = "Nikolov";
        sbyte age = 33;
        char gender = 'm';
        long personalID = 8306112507;
        int employeeNumber = 27561515;
        Console.WriteLine("Employee name: {0} {1}\nEmployee age: {2}\nEmployee gender: {3}\nEmployee personal ID: {4}\nEmployee number: {5}",
            firstName, lastName, age, gender, personalID, employeeNumber);
    }
}

