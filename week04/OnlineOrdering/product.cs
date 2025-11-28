public class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name,string id,decimal price,int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()=> _productName;
    public string GetId() => _productId;
    public decimal GetPrice()=> _price;
    public int GetQuantity()=> _quantity;

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }
}