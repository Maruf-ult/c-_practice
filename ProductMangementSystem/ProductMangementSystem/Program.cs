using ProductMangementSystem.interfaces;
using ProductMangementSystem.Interfaces;
using ProductMangementSystem.Models;
using ProductMangementSystem.Repository;
using ProductMangementSystem.Services;

namespace ProductMangementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductRepository repository = new ProductRepository();
             IProductService  service = new  ProductService(repository);

            service.ShowAllProducts();
            Console.WriteLine();
            service.AddProduct(new Product {  Name = "Product 4", Price = 40.0 });
            Console.WriteLine();
            Product product = service.GetProductById(2);
            Console.WriteLine($"{product.Id}-{product.Name}-{product.Price}");
            Console.WriteLine();
            service.DeleteProduct(3);
            Console.WriteLine();
            service.ShowAllProducts();

        }
    }
}
