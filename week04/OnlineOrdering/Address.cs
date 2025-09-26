public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _country;

// Constructor to initialize address details
    public Address(string street, string city, string state, string province, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }
   
    public string GetStreet()
    {
        return _street;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetState()
    {
        return _state;
    }

    public string GetProvince()
    {
        return _province;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}, {_city}, {_state} {_province}, {_country}");
    }
}