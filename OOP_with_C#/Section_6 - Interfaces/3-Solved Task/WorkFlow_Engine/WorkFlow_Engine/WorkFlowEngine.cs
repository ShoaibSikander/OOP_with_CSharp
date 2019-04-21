using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (ITask I in workflow.GetTasks())
            {
                try
                {
                    I.executeOperation();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
