using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlow_Engine
{
    class VideoUploader : ITask
    {
        public void executeOperation()
        {
            Console.WriteLine("Video is being uploaded... Done ...!");
            Console.WriteLine();
        }
    }
}
