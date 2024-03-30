public class Order
{
    private double _shippingCost;

    List<Product> _products = new List<Product>();

    private string _customerName;
    private string _customerAddress;

    public Order(Customer customer)
    {
        _customerName = customer.GetName();
        _customerAddress = customer.GetAddress();
        if (customer.IsUSA())
        {
            _shippingCost = 5.00;
        }
        else
        {
            _shippingCost = 35.00;
        }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateProductCost();
        }
        return total + _shippingCost;
    }

    public void PrintPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetName()}");
            Console.WriteLine($"Product ID: {product.GetId()}");
        }
    }

    public void PrintShippingLabel()
    {
        Console.WriteLine($"Customer Name: {_customerName}");
        Console.WriteLine($"Customer Address: {_customerAddress}");
    }
}