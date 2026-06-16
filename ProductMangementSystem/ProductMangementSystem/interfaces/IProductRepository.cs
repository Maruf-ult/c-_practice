using ProductMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMangementSystem.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        
    }
}
