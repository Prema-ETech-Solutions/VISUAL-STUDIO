using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysqlTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string con = "server=localhost;userid=root;password=;database=test";
                MySqlConnection conn = new MySqlConnection(con);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("create table if not exists test.sample(eid int,ename varchar(30),salary int", conn);
                cmd.ExecuteNonQuery();
                Console.WriteLine("table created suessfully");
                conn.Close();

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
            Console.ReadLine();
            
        }
    }
}
