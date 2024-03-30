public class Customer
{
    private string _name;

    private string _address;
    private bool _isUSA;

    public Customer(string customer, Address address)
    {
        _name = customer;
        _address = address.GetString();
        _isUSA = address.IsUSA();
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address;
    }

    public bool IsUSA()
    {
        return _isUSA;
    }
}