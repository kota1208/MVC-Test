using Dapper;
using MVC_Test.Models;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace MVC_Test.dapper
{
    public class ProductDapper
    {    

        public static List<CityEntity> GetProductAll()
        {
            //SqlConnection connection = SqlServerConnector.GetConnection();
            MySqlConnection connection = MySqlConnectoer.GetConnection();

            //sql文
            //string sql = @"select *from product";

            //MySql との接続確認用のsql
            string sql = "SELECT*FROM city";

            //sqlの実行
            //return connection.Query<ProductEntity>(sql).ToList();
            return connection.Query<CityEntity>(sql).ToList();

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
