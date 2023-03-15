using System;
using System.Collections.Generic;
namespace BrandonButtlarChallengeM7;

class Program
{
    static void Main(string[] args)
    {
        CustomerList customerList = new CustomerList();
        customerList.Changed += CustomerList_Updated;

        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add a new customer");
            Console.WriteLine("2. Delete a customer");
            Console.WriteLine("3. Exit the program");

            string option = Console.ReadLine();

            switch (option)
            {
                // Add a customer object to customerList
                case "1":
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter ID: ");
                    string id = Console.ReadLine();

                    Customer customer = new Customer(firstName, lastName, email, id);
                    customerList.Add(customer);
                    Console.WriteLine("Customer added successfully\n");
                    break;

                // Delete a customer object from customerList
                case "2":
                    Console.Write("Enter customer ID to delete: ");
                    string customerId = Console.ReadLine();

                    bool inList = false;
                    for (int i = 0; i < customerList.Count; i++)
                    {
                        if (customerList[i].ID == customerId)
                        {
                            customerList.Remove(customerList[i]);
                            Console.WriteLine("Customer deleted successfully\n");
                            inList = true;
                            break;
                        }
                    }

                    if (!inList)
                    {
                        Console.WriteLine("Customer not found\n");
                    }
                    break;

                // Exit the application
                case "3":
                    Console.WriteLine("\nExiting...\n");
                    return;

                default:
                    Console.WriteLine("\nInvalid option\n");
                    break;
            }
        }
    }

    // Event method that displays all customers in the current customer list
    static void CustomerList_Updated(CustomerList customers)
    {
        Console.WriteLine("\nCustomer List:");
        for (int i = 0; i < customers.Count; i++)
        {
            Console.WriteLine(customers[i].GetDisplayText());
        }
        Console.WriteLine("");
    }
}
