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
            Console.WriteLine("Welcome to Database Command Task!!!\n");
            Console.WriteLine("--------------------------------------------------------------\n");
            TimeSpan Time = new TimeSpan(0,0,10);

            var sqlConnection = new SqlConnection();
            var oracleConnection = new OracleConnection();

            var sqlInstruction = "SQL work is going on!!!";
            var oracleInstruction = "Oracle work is going on!!!";

            var SQLCommand = new DbCommand(sqlConnection, sqlInstruction);
            Console.WriteLine();

            var OracleCommand = new DbCommand(oracleConnection, oracleInstruction);
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------------------------\n");
        }
    }
}
