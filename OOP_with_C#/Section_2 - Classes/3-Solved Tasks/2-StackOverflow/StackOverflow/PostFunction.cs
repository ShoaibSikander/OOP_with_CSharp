using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class PostFunction
    {
        private int VoteCount = 0;

        public string PostTitle { get; set; }
        public string PostDescription { get; set; }
        public DateTime TimeCreated { get; set; }

        public int Vote(string vote)
        {
            if (vote == "+")
            {
                Console.WriteLine("Post is up-voted!");
                VoteCount++;
            }

            if (vote == "-")
            {
                Console.WriteLine("Post is down-voted!");
                VoteCount--;
            }
            return VoteCount;
        }
    }
}
