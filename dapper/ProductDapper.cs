using Dapper;
using MVC_Test.Models;
using System.Data.SqlClient;

namespace MVC_Test.dapper
{
    public class ProductDapper
    {    

        public static List<ProductEntity> GetProductAll()
        {
            SqlConnection connection = SqlServerConnector.GetConnection();
            //sql文
            string sql = @"select *from product";

            //sqlの実行
            return connection.Query<ProductEntity>(sql).ToList();

        }

        public static void DapperInsert(ProductEntity product)
        {
            SqlConnection connection =SqlServerConnector.GetConnection();
            string sql = @"insert into product(ProductName,productPrice)values(@ProductName,@ProductPrice);";
            //sqlの実行
            connection.Execute(sql, new
            {
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
            });
        }
    }
}
