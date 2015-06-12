using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 32;
        char gender = 'm';
        ulong personalIDNumber = 8306112507;
        uint uniqueEmployeeNumber = 27564832;

        Console.WriteLine("Employee {0} {1} is {2} years old, his/her gender is {3}, his/her personal ID number is {4}, his/her Unique employee number is {5} ", firstName, lastName, age, gender, personalIDNumber, uniqueEmployeeNumber);
    }
}
