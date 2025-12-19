using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Inventory.DAL.Repositories
{
    public class SupplierRepository
    {
        public DataTable GetAll()
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var da = new SqlDataAdapter(@"
SELECT SupplierId, Name, Phone, Email, Address
FROM Suppliers
ORDER BY SupplierId DESC;", con);

            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insert(string name, string? phone, string? email, string? address)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand(@"
INSERT INTO Suppliers (Name, Phone, Email, Address)
VALUES (@Name, @Phone, @Email, @Address);
SELECT SCOPE_IDENTITY();", con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", (object?)phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object?)email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object?)address ?? DBNull.Value);

            con.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Update(int supplierId, string name, string? phone, string? email, string? address)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand(@"
UPDATE Suppliers
SET Name=@Name, Phone=@Phone, Email=@Email, Address=@Address
WHERE SupplierId=@SupplierId;", con);

            cmd.Parameters.AddWithValue("@SupplierId", supplierId);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Phone", (object?)phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Email", (object?)email ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Address", (object?)address ?? DBNull.Value);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int supplierId)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand("DELETE FROM Suppliers WHERE SupplierId=@SupplierId;", con);
            cmd.Parameters.AddWithValue("@SupplierId", supplierId);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
