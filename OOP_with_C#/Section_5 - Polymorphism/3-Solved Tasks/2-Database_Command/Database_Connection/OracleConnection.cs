using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    public class OracleConnection : DbConnection
    {
        public override void OpenConnection(string ConnectionString, TimeSpan Timeout)
        {
            if (!string.IsNullOrEmpty(ConnectionString))
            {
                Console.WriteLine("Opened Oracle Connection");
                Console.WriteLine("Connection String: " + ConnectionString);
                Console.WriteLine("This Oracle Connection will close automatically after " + Timeout + " seconds.");
            }
            else
            {
                Console.WriteLine("Error: the ConnectionString is empty");
            }
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closed Oracle Connection");
        }
    }
}
