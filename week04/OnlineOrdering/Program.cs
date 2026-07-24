using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- Setup Addresses and Customers ---
        Address addressUSA = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customerUSA = new Customer("John Doe", addressUSA);

        Address addressInternational = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customerInternational = new Customer("Jane Smith", addressInternational);

        // --- Setup Products ---
        Product p1 = new Product("Laptop", "TECH-001", 999.99, 1);
        Product p2 = new Product("Mouse", "TECH-002", 25.50, 2);
        Product p3 = new Product("Keyboard", "TECH-003", 45.00, 1);
        
        Product p4 = new Product("Headphones", "AUDIO-101", 150.00, 1);
        Product p5 = new Product("USB Cable", "ACC-505", 10.00, 5);

        // --- Create Orders ---
        List<Product> order1Items = new List<Product> { p1, p2 };
        Order order1 = new Order(customerUSA, order1Items);

        List<Product> order2Items = new List<Product> { p3, p4, p5 };
        Order order2 = new Order(customerInternational, order2Items);

        List<Order> orders = new List<Order> { order1, order2 };

        // --- Process and Display Orders ---
        Console.WriteLine("--- Online Ordering System ---\n");

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotal():F2}");
            Console.WriteLine(new string('-', 30)); // Separator line
        }
    }
}