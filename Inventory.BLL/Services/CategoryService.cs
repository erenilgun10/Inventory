using System;
using System.Data;
using Inventory.DAL.Repositories;

namespace Inventory.BLL.Services
{
    public class CategoryService
    {
        private readonly CategoryRepository categoryRepository = new();

        public DataTable GetAll()
        {
            return categoryRepository.GetAll();
        }

        public int Add(string? name)
        {
            name = (name ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.");

            return categoryRepository.Insert(name);
        }

        public void Update(int categoryId, string? name)
        {
            if (categoryId <= 0)
                throw new ArgumentException("Invalid category id.");

            name = (name ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Category name cannot be empty.");

            categoryRepository.Update(categoryId, name);
        }

        public void Delete(int categoryId)
        {
            if (categoryId <= 0)
                throw new ArgumentException("Invalid category id.");

            categoryRepository.Delete(categoryId);
        }
    }
}
