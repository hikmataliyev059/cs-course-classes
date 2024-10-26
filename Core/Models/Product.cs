using Core.Helpers.Enums;

namespace Core.Models;

public class Product
{
    private static int _noCounter;

    public int No { get; }
    public string Name { get; set; }
    public double Price { get; set; }
    public Types Type { get; }

    public Product(string name, double price)
    {
        No = ++_noCounter;
        Name = name;
        Price = price;
    }
    
}