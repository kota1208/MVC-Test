

using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace MVC_Test.dapper
{

  
    public class MySqlConnectoer
    {

        //接続文字列
        private static string _connectionString;
        //コネクションにシングルトンパターンを適用させる
        static MySqlConnection connection = null;

        //static なコンストラクタ
        static MySqlConnectoer()
        {
            string server = "localhost";
            string database = "sakila";    // デフォルトで存在するデーターベース
            string user = "root";
            string pass = "password";
            string charset = "utf8";    // 文字コードセット
            string connectionString = string.Format("Server={0};Database={1};Uid={2};Pwd={3};Charset={4}", server, database, user, pass, charset);

           
            connection = new MySqlConnection(connectionString);

                
        }

        public static MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
