using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("54 Main St","Salt Lake","Utah","USA");
        Customer customer1 = new Customer("Joe Smith",address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop","A100",1200m,1));
        order1.AddProduct(new Product("Mouse","M200",25m,2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total price: ${order1.GetTotalPrice()}\n");

        Address address2 = new Address("896 Thando St","Hermanus","Western Cape","SA");
        Customer customer2 = new Customer("Mandla Xaluva",address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone","H300",100m,1));
        order2.AddProduct(new Product("Earpods","B250",45m,1));
        order1.AddProduct(new Product("Stereo set","A470",150m,1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total price: ${order2.GetTotalPrice()}\n");

    }
}