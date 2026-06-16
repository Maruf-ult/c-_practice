using ProductMangementSystem.Interfaces;
using ProductMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMangementSystem.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id = 1, Name = "maruf", Price = 32.2 },
                new Product { Id = 2, Name = "karum", Price = 20.2 },
                new Product { Id = 3, Name = "qwerty", Price = 45.3 },
                new Product { Id = 4, Name = "asdfd", Price = 12.3 }
            };
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }

       
    }
}
