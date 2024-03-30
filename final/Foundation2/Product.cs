public class Product
{
    private string _name;
    private double _price;
    private double _quantity;
    private int _id;

    public Product(string name, double price, int quantity, int id)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = id;
    }

    public double CalculateProductCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetId()
    {
        return _id;
    }
}