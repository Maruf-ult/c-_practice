using ProductMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMangementSystem.interfaces
{
    public interface IProductService
    {
        void ShowAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void DeleteProduct(int id);
    }
}
