using System;

class Program
{
    static void Main(string[] args)
    {
        // address 1
        Address address1 = new Address(
            "144 Center Street",
            "Snowflake",
            "Arizona",
            "USA"
        );

        // customer 1
        Customer customer1 = new Customer(
            "Jake from StateFarm",
            address1
        );
        // order 1
        Order order1 = new Order(customer1);

        // add products to order 1
        order1.AddProduct(
            new Product("iMac", "cs1024", 1299.00m, 4)
        );
        order1.AddProduct(
            new Product("Magic Mouse", "mm2", 79.00m, 4)
        );
        order1.AddProduct(
            new Product("Wireless Keyboard with Number Pad", "wwk2", 209.00m, 4)
        );
        
        // address 2
        Address address2 = new Address(
            "1197 Mason Ave SW",
            "Vancouver",
            "British Columbia",
            "Canada"
        );

        // customer 2
        Customer customer2 = new Customer(
            "Carson Simmons",
            address2
        );

        // order 2
        Order order2 = new Order(customer1);

        // add products to order 2
        order2.AddProduct(
            new Product("MacBook Air", "ma134", 899.00m, 7)
        );
        order2.AddProduct(
            new Product("MacBook Pro", "mp164", 2179.00m, 2)
        );

        // display order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine(
            $"Total Price: ${order1.CalculateTotalPrice():F2}"
            );

        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine();

        // display order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine();
        Console.WriteLine(
            $"Total Price: ${order2.CalculateTotalPrice():F2}"
        );
    }
}