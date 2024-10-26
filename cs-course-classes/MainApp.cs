using Core.Data;
using Core.Models;

namespace cs_course_classes;

public class MainApp
{
    
    public static void Main(string[] args)
    {
        Product product = new Product("Hikmət", 19);
        Product product1 = new Product("Ilkin", 18);
        Product product2 = new Product("Amil", 20);
        Product product3 = new Product("Ali", 17);
        
        ApDbContext.AddProduct(product);
        ApDbContext.AddProduct(product1);
        ApDbContext.AddProduct(product2);
        ApDbContext.AddProduct(product3);

        ApDbContext.RemoveProduct(3);

        foreach (var item in ApDbContext.GetAll())
        {
            Console.WriteLine($"{item.No} {item.Name} {item.Price}");
        }
    }
    
}