using System;
using System.Data;
using Inventory.DAL.Repositories;

namespace Inventory.BLL.Services
{
    public class StockMovementService
    {
        private readonly StockMovementRepository _repo = new();

        public DataTable GetAll()
        {
            return _repo.GetAll();
        }

        public int Add(int productId,string? movementType,int quantity,decimal unitPrice,string? note,DateTime movementDate)
        {
            movementType = (movementType ?? string.Empty).Trim();
            note = (note ?? string.Empty).Trim();

            if (productId <= 0)
                throw new ArgumentException("Invalid product.");

            if (string.IsNullOrWhiteSpace(movementType))
                throw new ArgumentException("Movement type cannot be empty.");

            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            if (unitPrice < 0)
                throw new ArgumentException("Unit price cannot be negative.");

            return _repo.Insert(
                productId,
                movementType,
                quantity,
                unitPrice,
                string.IsNullOrWhiteSpace(note) ? null : note,
                movementDate
            );
        }

        public void Delete(int movementId)
        {
            if (movementId <= 0)
                throw new ArgumentException("Invalid movement id.");

            _repo.Delete(movementId);
        }
    }
}
