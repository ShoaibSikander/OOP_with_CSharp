using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to StackOverflow!");
            Console.WriteLine("Press + to up-vote and - for down-vote");
            Console.WriteLine("Press Control+C to exit");
            Console.WriteLine(Environment.NewLine);

            var post = new PostFunction();
            post.PostTitle = "Post Title : Solving C# issues";
            post.PostDescription = "Post Description : C# issue description";
            post.TimeCreated = DateTime.Now;
            Console.WriteLine(post.PostTitle);
            Console.WriteLine(post.PostDescription);
            Console.WriteLine("Post created on : " + post.TimeCreated);
            Console.WriteLine(Environment.NewLine);

            do
            {
                Console.WriteLine("Enter your choice : ");
                var vote = Console.ReadLine();

                if (vote == "+")
                    post.Vote("+");

                if (vote == "-")
                    post.Vote("-");

                int NumVotes = post.Vote(" ");
                Console.WriteLine("Votes Status for the post : " + NumVotes + "\n");
            }
            while (true);
        }
    }
}
