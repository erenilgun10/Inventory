using System;
using System.Data;
using Inventory.DAL.Repositories;

namespace Inventory.BLL.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository = new();

        public DataTable GetAll()
        {
            return _productRepository.GetAll();
        }

        public int Add(string? barcode, string name, int? categoryId, int? supplierId, decimal purchasePrice,
            decimal salePrice, int stock, int minStock)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name cannot be empty.");

            if (purchasePrice < 0 || salePrice < 0)
                throw new ArgumentException("Prices cannot be negative.");

            if (salePrice < purchasePrice)
                throw new ArgumentException("Sale price cannot be lower than purchase price.");

            if (stock < 0 || minStock < 0)
                throw new ArgumentException("Stock values cannot be negative.");

            return _productRepository.Insert(barcode?.Trim(), name.Trim(), categoryId, supplierId, purchasePrice, salePrice, stock, minStock);
        }


        public void Update(
            int productId,
            string? barcode,
            string name,
            int? categoryId,
            int? supplierId,
            decimal purchasePrice,
            decimal salePrice,
            int stock,
            int minStock
        )
        {
            if (productId <= 0)
                throw new ArgumentException("Invalid product id.");

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name cannot be empty.");

            if (purchasePrice < 0 || salePrice < 0)
                throw new ArgumentException("Prices cannot be negative.");

            if (salePrice < purchasePrice)
                throw new ArgumentException("Sale price cannot be lower than purchase price.");

            if (stock < 0 || minStock < 0)
                throw new ArgumentException("Stock values cannot be negative.");

            _productRepository.Update(productId, barcode?.Trim(), name.Trim(), categoryId, supplierId, purchasePrice, salePrice,stock, minStock
            );
        }


        public void Delete(int productId)
        {
            if (productId <= 0)
                throw new ArgumentException("Invalid product id.");

            _productRepository.Delete(productId);
        }
    }
}
