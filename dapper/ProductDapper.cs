using Dapper;
using MVC_Test.Models;
using System.Data.SqlClient;

namespace MVC_Test.dapper
{
    public class ProductDapper
    {

        static SqlConnection connection = null;
        //Javaでのstaticイニシャライザー
        static ProductDapper()
        {
            if(connection == null)
            {
                //Connectionの取得
                connection = SqlServerConnector.GetConnection();
            }
        }

        public static List<ProductEntity> GetProductAll()
        {
            //sql文
            string sql = @"select *from product";

            //dbと接続する
            using (connection)
            {
                    
                return connection.Query<ProductEntity>(sql).ToList();
                

            }
        }
    }
}
