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
    public class SqlServerConnector
    {
        //接続文字列
        private static string _connectionString;
        //コネクションにシングルトンパターンを適用させる
        static SqlConnection ?connection = null;

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
            //未接続であればDBに接続を行う
            if(connection == null)
            {
                connection = new SqlConnection(_connectionString);

            }
            return connection;
        }

       
        
    }
}