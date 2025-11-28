public class Order
{
    private List<Product>_product = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal productTotal = 0;

        foreach (var p in _product)
        {
            productTotal += p.GetTotalCost();
        }

        decimal shippingCost = _customer.LivesInUSA()? 5:35;
        return productTotal+shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label: \n";

        foreach (var p in _product)
        {
            label += $"{p.GetName()}- {p.GetId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL:\n{_customer.GetName()}\n {_customer.GetAddress().GetFullAddress()}";
    }
}