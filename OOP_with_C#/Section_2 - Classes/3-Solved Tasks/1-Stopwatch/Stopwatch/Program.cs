using System;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome!");
            var objectStopwatch = new Function_Stopwatch();

            do
            {
                Console.WriteLine("Press Enter to Start the Stopwatch");
                Console.WriteLine("Press Ctrl+C to exit");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Stopwatch started at: " + objectStopwatch.Start());
                    Console.WriteLine("Press Enter again to stop the Stopwatch");
                }

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Stopwatch stopped at: " + objectStopwatch.Stop());
                }

                Console.WriteLine("Duration: " + objectStopwatch.Duration());
                Console.WriteLine(Environment.NewLine);
            } while (true);
        }
    }
}
