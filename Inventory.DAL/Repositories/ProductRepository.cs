using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Inventory.DAL.Repositories;

public class ProductRepository
{
    public DataTable GetAll()
    {
        using var con = new SqlConnection(Db.ConnectionString);
        using var da = new SqlDataAdapter(@"
SELECT ProductId, Barcode, Name, Stock, MinStock, PurchasePrice, SalePrice, IsActive, CreatedAt
FROM Products
ORDER BY ProductId DESC", con);

        var dt = new DataTable();
        da.Fill(dt);
        return dt;
    }

    public int Insert(string? barcode, string name, int stock, int minStock)
    {
        using var con = new SqlConnection(Db.ConnectionString);
        using var cmd = new SqlCommand(@"
INSERT INTO Products (Barcode, Name, CategoryId, SupplierId, PurchasePrice, SalePrice, Stock, MinStock, IsActive, CreatedAt)
VALUES (@Barcode, @Name, NULL, NULL, 0, 0, @Stock, @MinStock, 1, GETDATE());
SELECT SCOPE_IDENTITY();", con);

        cmd.Parameters.AddWithValue("@Barcode", (object?)barcode ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Stock", stock);
        cmd.Parameters.AddWithValue("@MinStock", minStock);

        con.Open();
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    public void Update(int productId, string? barcode, string name, int stock, int minStock)
    {
        using var con = new SqlConnection(Db.ConnectionString);
        using var cmd = new SqlCommand(@"
UPDATE Products
SET Barcode=@Barcode, Name=@Name, Stock=@Stock, MinStock=@MinStock
WHERE ProductId=@ProductId;", con);

        cmd.Parameters.AddWithValue("@ProductId", productId);
        cmd.Parameters.AddWithValue("@Barcode", (object?)barcode ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Stock", stock);
        cmd.Parameters.AddWithValue("@MinStock", minStock);

        con.Open();
        cmd.ExecuteNonQuery();
    }

    public void Delete(int productId)
    {
        using var con = new SqlConnection(Db.ConnectionString);
        using var cmd = new SqlCommand("DELETE FROM Products WHERE ProductId=@ProductId;", con);
        cmd.Parameters.AddWithValue("@ProductId", productId);

        con.Open();
        cmd.ExecuteNonQuery();
    }
}