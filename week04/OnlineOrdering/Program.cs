using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Online Ordering System!");

        // Create a customer and address
        Customer customer = new Customer("John Doe", "123 Main St, Springfield, IL");
        Address address = new Address("123 Main St", "Springfield", "IL", "USA", "USA");

        // Create a new order
        Order order = new Order(customer, address);

        // Add items to the order
        order.AddProduct(new Product("Bicycle", "B01", 999.99, 1));
        order.AddProduct(new Product("Trailor", "T02", 25.50, 2));
        order.AddProduct(new Product("Laptop", "L03", 45.00, 1));

        order.GetPackingLabel();
        
        order.GetShippingLabel();

        // Display the order summary
        order.DisplayOrderDetails();

        // Calculate and display the total cost
        decimal totalCost = (decimal)order.CalculateTotalPrice();
        Console.WriteLine($"Total Cost Including Shipping: ${totalCost:F2}");

        Console.WriteLine("Thank you for using the Online Ordering System!");
    }
}