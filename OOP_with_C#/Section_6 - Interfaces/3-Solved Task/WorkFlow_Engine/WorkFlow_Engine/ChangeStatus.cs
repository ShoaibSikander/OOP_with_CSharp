using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    class ChangeStatus : ITask
    {
        public void executeOperation()
        {
            Console.WriteLine("Status is being changed... Done ...!");
            Console.WriteLine();
        }
    }
}
