using System;
using System.Data;
using Inventory.DAL.Repositories;

namespace Inventory.BLL.Services
{
    public class SupplierService
    {
        private readonly SupplierRepository supplierRepository = new();

        public DataTable GetAll()
        {
            return supplierRepository.GetAll();
        }

        public int Add(string? name, string? phone, string? email, string? address)
        {
            name = (name ?? string.Empty).Trim();
            phone = (phone ?? string.Empty).Trim();
            email = (email ?? string.Empty).Trim();
            address = (address ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Supplier name cannot be empty.");

            return supplierRepository.Insert(
                name,
                string.IsNullOrWhiteSpace(phone) ? null : phone,
                string.IsNullOrWhiteSpace(email) ? null : email,
                string.IsNullOrWhiteSpace(address) ? null : address
            );
        }

        public void Update(int supplierId, string? name, string? phone, string? email, string? address)
        {
            if (supplierId <= 0)
                throw new ArgumentException("Invalid supplier id.");

            name = (name ?? string.Empty).Trim();
            phone = (phone ?? string.Empty).Trim();
            email = (email ?? string.Empty).Trim();
            address = (address ?? string.Empty).Trim();

            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Supplier name cannot be empty.");

            supplierRepository.Update(
                supplierId,
                name,
                string.IsNullOrWhiteSpace(phone) ? null : phone,
                string.IsNullOrWhiteSpace(email) ? null : email,
                string.IsNullOrWhiteSpace(address) ? null : address
            );
        }

        public void Delete(int supplierId)
        {
            if (supplierId <= 0)
                throw new ArgumentException("Invalid supplier id.");

            supplierRepository.Delete(supplierId);
        }
    }
}
