using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    class SendEmail : ITask
    {
        public void executeOperation()
        {
            Console.WriteLine("Email is being sent... Done ...!");
            Console.WriteLine();
        }
    }
}
