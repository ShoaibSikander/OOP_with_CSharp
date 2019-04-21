using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITask> myListTasks;

        public Workflow()
        {
            myListTasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            myListTasks.Add(task);
        }

        public void Remove(ITask task)
        {
            myListTasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return myListTasks;
        }
    }
}
