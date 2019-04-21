using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Database Connection Task!!!\n");
            Console.WriteLine("--------------------------------------------------------------\n");
            TimeSpan Time = new TimeSpan(0,0,10);

            string SQLConnectionString = "SQL Connection string instantiated!!!";
            string OracleConnectionString = "Oracle Connection string instantiated!!!";

            var sqlConnection = new SqlConnection();
            var oracleConnection = new OracleConnection();

            sqlConnection.OpenConnection(SQLConnectionString, Time);
            sqlConnection.CloseConnection();
            Console.WriteLine();

            oracleConnection.OpenConnection(OracleConnectionString, Time);
            oracleConnection.CloseConnection();
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------\n");
        }
    }
}