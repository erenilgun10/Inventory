using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Inventory.DAL.Repositories
{
    public class CategoryRepository
    {
        public DataTable GetAll()
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var da = new SqlDataAdapter(@"
SELECT CategoryId, Name
FROM Categories
ORDER BY CategoryId;", con);

            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insert(string name)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand(@"
INSERT INTO Categories (Name)
VALUES (@Name);
SELECT SCOPE_IDENTITY();", con);

            cmd.Parameters.AddWithValue("@Name", name);

            con.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public void Update(int categoryId, string name)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand(@"
UPDATE Categories
SET Name=@Name
WHERE CategoryId=@CategoryId;", con);

            cmd.Parameters.AddWithValue("@CategoryId", categoryId);
            cmd.Parameters.AddWithValue("@Name", name);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(int categoryId)
        {
            using var con = new SqlConnection(Db.ConnectionString);
            using var cmd = new SqlCommand("DELETE FROM Categories WHERE CategoryId=@CategoryId;", con);
            cmd.Parameters.AddWithValue("@CategoryId", categoryId);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
