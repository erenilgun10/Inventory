using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Inventory.DAL.Repositories
{
    public class StockMovementRepository
    {
        public DataTable GetAll()
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var da = new SqlDataAdapter(@"
SELECT MovementId, ProductId, MovementType, Quantity, UnitPrice, Note, MovementDate
FROM StockMovements
ORDER BY MovementDate DESC, MovementId DESC;", con);

            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insert(int productId, string movementType, int quantity, decimal unitPrice, string? note, DateTime movementDate)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand(@"
INSERT INTO StockMovements (ProductId, MovementType, Quantity, UnitPrice, Note, MovementDate)
VALUES (@ProductId, @MovementType, @Quantity, @UnitPrice, @Note, @MovementDate);
SELECT SCOPE_IDENTITY();", con);

            cmd.Parameters.AddWithValue("@ProductId", productId);
            cmd.Parameters.AddWithValue("@MovementType", movementType);
            cmd.Parameters.AddWithValue("@Quantity", quantity);
            cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
            cmd.Parameters.AddWithValue("@Note", (object?)note ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MovementDate", movementDate);

            con.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Delete(int movementId)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand("DELETE FROM StockMovements WHERE MovementId=@MovementId;", con);
            cmd.Parameters.AddWithValue("@MovementId", movementId);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
