using MainLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerGroup customergroup1 = new CustomerGroup()
            {
                count = 3,
                category = "A"
            };
            Console.WriteLine("List of Customers");
            foreach (var cust in customergroup1.customers)
            {
                Console.WriteLine($"Name: {cust.DisplayName}");
            }
            
            Console.WriteLine("Customers starts with letter N");
            foreach (var cust in customergroup1.customers.Where(c => c.DisplayName.StartsWith("N") || c.DisplayName.StartsWith("n")).ToList())
            {
                Console.WriteLine($"Name:{cust.DisplayName} ");
            }

            Console.WriteLine("---------------------------------------------");
            Console.ReadLine();
        }
    }
}
