using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Connection
{
    partial class Program
    {
        public class DbCommand
        {
            public DbConnection Connection { get; set; }
            public string Instruction { get; set; }

            public DbCommand(DbConnection Connection, string Instruction)
            {
                Console.WriteLine("Connection  : " + Connection);
                Console.WriteLine("Instruction : " + Instruction);

                Execute(Instruction);
            }

            public void Execute(string Instruction)
            {
                Console.WriteLine("Open the connection");
                Console.WriteLine("Run the instruction");
                Console.WriteLine("Close the connection");
            }
        }
    }
}
