public class Order
{
    private Customer _customer;
    private List<Product> _products;
    private Address _address;

    public Order()
    {
    }

    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

// Calculate total price including shipping
    public double CalculateTotalPrice()
    {
        double total = 0;
        
        foreach (var product in _products)
        {
            double shippingcost = 0;
            if (_address.GetCountry() == "USA")
            {
                shippingcost = 5.00;
            }
            else
            {
                shippingcost = 35.00;
            }
            total += product.GetPrice() * product.GetQuantity() + shippingcost;
        }
        return total;
    }
// Display order details
    public void DisplayOrderDetails()
    {
        Console.WriteLine("Order Details:");
        _customer.DisplayInfo();
        Console.WriteLine("Shipping Address:");
        _address.DisplayAddress();
        Console.WriteLine("Products:");

        foreach (var product in _products)
        {
            product.DisplayInfo();
            Console.WriteLine();
        }
        double totalPrice = CalculateTotalPrice();
        
    }
}