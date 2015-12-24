using System;
using System.Collections.Generic;

namespace Problem_2.Customer
{
    class ProgramMain
    {
        static void Main()
        {
            Customer customer1 = new Customer(
                "Ivan",
                "Angelov",
                "Ivanov",
                8811056253,
                "Sofia, Obelq bl. 125",
                0899963125,
                "iivanov@abv.bg",
                CustomerType.OneTime,
                new Payment("Sony Bravia", 1500));

            Customer customer2 = customer1.Clone() as Customer;
            customer2.FirstName = "Georgi";
            customer2.MiddleName = "Petrov";
            customer2.LastName = "Georgiev";
            customer2.Id = 9105074815;

            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer1 == customer2);

            Customer customer3 = new Customer(
                "Dimitar",
                "Rangelov",
                "Dimitrov",
                9204261459,
                "Burgas, Slavejkov bl. 68",
                0888478125,
                "ddimitrov@mail.bg",
                CustomerType.Diamond,
                new Payment("Vafla Borovetz", 0.25));

            Customer customer4 = customer3.Clone() as Customer;
            customer4.Id = 7810100663;

            List<Customer> customers = new List<Customer> { customer1, customer2, customer3, customer4 };

            customers.Sort();
            Console.WriteLine(string.Join("\n", customers));
        }
    }
}