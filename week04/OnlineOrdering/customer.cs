public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string name,Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetName()=> _customerName;
    public Address GetAddress()=> _address;

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}