using Dapper;
using MVC_Test.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Test.dapper
{
    public static class SqlServerConnector
    {
        private static string _connectionString;
        //static なコンストラクタ
        static SqlServerConnector()
        {
            //dbに接続するための接続文字列を作成する
            //MSが簡単に作成できるように用意してくれいる
            var builder = new SqlConnectionStringBuilder();
            //PCの名前
            builder.DataSource = "DESKTOP-49CIQAK";
            //データベース名
            builder.InitialCatalog = "Test";
            //windows認証だとtrue,sqlserver認証だとfalse
            builder.IntegratedSecurity = true;
            //接続文字列の生成
            _connectionString = builder.ToString();


        }

        public static SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

       

        public static void DapperInsert(ProductEntity product)
        {
            string sql = @"insert into product(ProductName,productPrice)values(@ProductName,@ProductPrice);";



            //dbと接続する
            using (var connection = GetConnection())
            {


                connection.Execute(sql, new
                {
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice,
                });

            }
        }
    }
}