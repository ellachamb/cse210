using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Shoes", 40.00, 5, 1);
        Product product2 = new Product("Picture", 20.00, 10, 2);
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer = new Customer("Jane Doe", address);
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);
        Console.WriteLine("Order Summary:");
        order.PrintPackingLabel();
        Console.WriteLine($"Total Cost: ${order.CalculateTotal()}.00");
        order.PrintShippingLabel();
        Console.WriteLine();

        Product product3 = new Product("Dress", 50.00, 3, 3);
        Product product4 = new Product("Phone", 500.00, 1, 4);
        Address address2 = new Address("123 Avenue des Champs", "Paris", "75008", "France");
        Customer customer2 = new Customer("Louis DeVon", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        Console.WriteLine("Order Summary:");
        order2.PrintPackingLabel();
        Console.WriteLine($"Total Cost: ${order2.CalculateTotal()}.00");
        order2.PrintShippingLabel();
        Console.WriteLine();


    }
}