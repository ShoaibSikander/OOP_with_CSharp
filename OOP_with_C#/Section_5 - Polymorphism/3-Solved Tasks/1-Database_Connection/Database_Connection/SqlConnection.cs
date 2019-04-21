using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    public class SqlConnection : DbConnection
    {
        public override void OpenConnection(string ConnectionString, TimeSpan Timeout)
        {
            if (!string.IsNullOrEmpty(ConnectionString))
            {
                Console.WriteLine("Opened SQL Connection");
                Console.WriteLine("Connection String: " + ConnectionString);
                Console.WriteLine("This SQL Connection will close automatically after "+ Timeout +" seconds.");
            }
            else
            {
                Console.WriteLine("Error:  Empty Connection String provided!!!");
            }
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closed SQL Connection");
        }
    }
}
