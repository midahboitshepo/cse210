public class Customer
{
    private string _name;
    private string _address;

// Constructor to initialize customer details
    public Customer(string name, string address)
    {
        _name = name;
        _address = address;
    }

// Getters for customer details
    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address;
    }

// Display customer information
    public void DisplayInfo()
    {
        Console.WriteLine($"Customer Name: {_name}");
        Console.WriteLine($"Customer Address: {_address}");
    }
}