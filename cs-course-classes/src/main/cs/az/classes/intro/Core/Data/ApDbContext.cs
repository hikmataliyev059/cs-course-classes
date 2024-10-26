using Core.Helpers.Enums;
using Core.Models;

namespace Core.Data;

public static class ApDbContext
{
    
    static readonly List<Product> Products = new List<Product>();

    static readonly List<Store?> Stores = new List<Store?>();

    public static void AddProduct(Product? product)
    {
        if (product != null) Products.Add(product);
    }

    public static void RemoveProduct(int no)
    {
        Product? product = GetProductByNo(no);
        if (product != null) Products.Remove(product);
    }

    private static Product? GetProductByNo(int no)
    {
        return Products.Find(p => p.No == no);
    }

    public static List<Product> Filter(Types type)
    {
        return Products.FindAll(p => p.Type == type);
    }

    public static List<Product> Filter(string name)
    {
        return Products.FindAll(x => x.Name == name);
    }

    public static List<Product> GetAll()
    {
        return Products;
    }

    public static void AddStore(Store store)
    {
        Stores.Add(store);
    }

    public static void RemoveStore(Store store)
    {
        Stores.Remove(store);
    }
    
}