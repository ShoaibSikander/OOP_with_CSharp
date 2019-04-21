using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    public abstract class DbConnection
    {
        public string PropertyConnectionString { get; set; }
        private TimeSpan PropertyTimeout { get; set; }

        public abstract void OpenConnection(string ConnectionString, TimeSpan Timeout);
        public abstract void CloseConnection();
    }
}
