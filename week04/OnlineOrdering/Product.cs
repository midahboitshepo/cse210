public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private static int _quantity = 0;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

// Display product information
    public void DisplayInfo()
    {
        Console.WriteLine($"Product Name: {_name}");
        Console.WriteLine($"Product ID: {_id}");
        Console.WriteLine($"Product Price: ${_price:F2}");
        Console.WriteLine($"Product Quantity: {_quantity}");
    }
}