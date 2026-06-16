using ProductMangementSystem.interfaces;
using ProductMangementSystem.Interfaces;
using ProductMangementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMangementSystem.Services
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void ShowAllProducts()
        {
            var products = _productRepository.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }
        }

        public Product GetProductById(int id)
        {
            var product = _productRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                throw new Exception("Product not found");
            }
            return product;

        }

        public void AddProduct(Product product)
        {
            var maxId = _productRepository.GetAllProducts().Max(p => p.Id);
            product.Id = maxId + 1;
            _productRepository.GetAllProducts().Add(product);
        }

        public void DeleteProduct(int id)
        {
            var product = _productRepository.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new Exception("Product not found");
            }
            _productRepository.GetAllProducts().Remove(product);
        }
    }
}
