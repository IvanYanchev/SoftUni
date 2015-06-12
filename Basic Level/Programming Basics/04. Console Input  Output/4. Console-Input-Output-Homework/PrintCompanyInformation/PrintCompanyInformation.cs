using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Input Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Input Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Input Phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Input Fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Input Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Input Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Input Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Input Manager age: ");
        string managerAge = Console.ReadLine();
        Console.Write("Input Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(" {0} \n Address: {1} \n Tel. {2} \n Fax: {3} \n Web site: {4} \n Manager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, companyPhoneNumber, companyFaxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
    }
}