using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    class CallWebService : ITask
    {
        public void executeOperation()
        {
            Console.WriteLine("Web Service is being called ... Done ...!");
            Console.WriteLine();
        }
    }
}
