using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Product A", 101, 10.00m, 2));
        order1.AddProduct(new Product("Product B", 102, 15.00m, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Product C", 201, 20.00m, 3));
        order2.AddProduct(new Product("Product D", 202, 5.00m, 5));

        DisplayOrderDetails(order1);
        Console.WriteLine(new string('=', 40));
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: {order.CalculateTotalCost():C}");
    }
}