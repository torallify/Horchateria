using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Horchateria.Models
{
    public class DAL
    {
        SqlConnection connection;

        public DAL(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            //TODO: close the connection!!
        }

        //TODO: Use try/catches around 
        public IEnumerable<Product> GetProductCategories()
        {
            string queryString = "SELECT DISTINCT Category FROM Products";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }

        public IEnumerable<Product> GetProductsAll()
        {
            string queryString = "SELECT * FROM Products";
            IEnumerable<Product> Products = connection.Query<Product>(queryString);

            return Products;
        }



        public Product GetProductByID(int id)
        {
            string queryString = "SELECT * FROM Products WHERE Id = @val";
            Product prod = connection.QueryFirstOrDefault<Product>(queryString, new { val = id });

            return prod;
        }

        public IEnumerable<Product> GetProductsInCategory(string cat)
        {
            string queryString = "SELECT * FROM Products WHERE Category = @val";
            IEnumerable<Product> Products = connection.Query<Product>(queryString, new { val = cat });

            return Products;
        }

        public int CreateProduct(Product prod)
        {
            string addString = "INSERT INTO Products (Name, Description, Price, Category)";
            addString += "Values (@Name, @Description, @Price, @Category)";

            return connection.Execute(addString, prod);
        }

        public int DeleteProductById(int id)
        {
            string deleteString = "DELETE FROM Products WHERE Id = @val";
            return connection.Execute(deleteString, new { val = id });
        }

        public int UpdateProductById(Product prod)
        {
            string editString = "UPDATE Products SET Name = @Name, Description =  @Description, ";
            editString += "Price = @Price, Category = @Category WHERE Id = @Id";
            return connection.Execute(editString, prod);
        }
    }
}
